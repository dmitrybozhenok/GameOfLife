using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using DD.CommonPatterns;

namespace DD.Life.WinForms
{
    public sealed partial class LifeLauncher : Form
    {
        private int XRange => (int)txtWidth.Value;
        private int YRange => (int)txtHeight.Value;
        private int XOffset => (int)txtXOffset.Value;
        private int YOffset => (int)txtYOffset.Value;

        private Grid _grid;
        private readonly string _appName;

        private PatternInfo SelectedPattern => (PatternInfo)cmbPatterns.SelectedItem;

        public LifeLauncher()
        {
            InitializeComponent();

            Size = new Size(800, 600);
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

        private void OnPatternSelectionChanged(object sender, System.EventArgs e)
        {
            OnStopClick();

            var selectedPattern = SelectedPattern;
            txtBody.Text = selectedPattern.Value;

            // ReSharper disable once LocalizableElement
            Text = $"{_appName} ({selectedPattern.FullName})";

            RefreshGrid(selectedPattern);
        }

        private void RefreshGrid(PatternInfo selectedPattern)
        {
            var offset = new Point(XOffset, YOffset);
            var pattern = Pattern.Parse(selectedPattern.Value, XRange, YRange, offset);
            _grid = new Grid(XRange, YRange, pattern);
        }

        private void OnStartClick(object sender, System.EventArgs e)
        {
            RefreshGrid(SelectedPattern);
            txtBody.Text = _grid.ToString();

            tmrReevaluation.Start();
        }

        private void OnStopClick(object sender = null, System.EventArgs e = null)
        {
            tmrReevaluation.Stop();
        }

        private void OnReevaluationTick(object sender, System.EventArgs e)
        {
            _grid.Reevaluate();

            txtBody.Text = _grid.ToString();
        }

        private void OnTimeoutChanged(object sender, System.EventArgs e)
        {
            tmrReevaluation.Interval = (int)txtTimeout.Value;
        }
    }
}