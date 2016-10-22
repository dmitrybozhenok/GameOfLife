using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using DD.CommonPatterns;

namespace DD.Life.WinForms
{
    public sealed partial class LifeLauncher : Form
    {
        private Grid _grid;
        private readonly int _xRange = 16;
        private readonly int _yRange = 16;

        private readonly string _appName;

        public LifeLauncher()
        {
            InitializeComponent();

            txtBody.Text = null;

            _appName = Text;

            InitializePatterns();
        }

        private void InitializePatterns()
        {
            var commonPatternsAssembly = typeof(Spaceships).Assembly;
            var q = from t in commonPatternsAssembly.GetTypes()
                    where t.IsAbstract && t.IsSealed
                    from f in t.GetFields(BindingFlags.Public | BindingFlags.Static)
                    where f.FieldType == typeof(string)
                    select new PatternInfo(t.Name + "." + f.Name, (string)f.GetValue(null));

            var availablePatterns = q.ToArray();
            cmbPatterns.DataSource = availablePatterns;
        }

        public class PatternInfo
        {
            public string FullName { get; }
            public string Value { get; }

            public PatternInfo(string fullName, string value)
            {
                FullName = fullName;
                Value = value;
            }

            public override string ToString()
            {
                return FullName;
            }
        }

        private void cmbPatterns_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            EhlStop();

            var selectedPattern = (PatternInfo)cmbPatterns.SelectedItem;
            txtBody.Text = selectedPattern.Value;

            // ReSharper disable once LocalizableElement
            Text = $"{_appName} ({selectedPattern.FullName})";

            var pattern = Pattern.Parse(selectedPattern.Value, _xRange, _yRange);
            _grid = new Grid(_xRange, _yRange, pattern);
        }

        private void EhlStart(object sender, System.EventArgs e)
        {
            txtBody.Text = _grid.ToString();

            tmrReevaluation.Start();
        }

        private void EhlStop(object sender = null, System.EventArgs e = null)
        {
            tmrReevaluation.Stop();
        }

        private void tmrReevaluation_Tick(object sender, System.EventArgs e)
        {
            _grid.Reevaluate();

            txtBody.Text = _grid.ToString();
        }
    }
}