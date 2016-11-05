using System;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using DD.CommonPatterns;
using DD.Life;

namespace Life.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DD.Life.Grid _grid;
        private readonly int _xRange = 16;
        private readonly int _yRange = 16;

        private readonly DispatcherTimer _tmrReevaluation = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();

            TextBox.Text = null;
            _tmrReevaluation.Tick += tmrReevaluation_Tick;
            _tmrReevaluation.Interval = new TimeSpan(0, 0, 0, 0, 250);
        }

        private void tmrReevaluation_Tick(object sender, EventArgs e)
        {
            _grid.Reevaluate();

            TextBox.Text = _grid.ToString();
        }

        private void CmbPatterns_OnLoaded(object sender, RoutedEventArgs e)
        {
            var commonPatternsAssembly = typeof(Spaceships).Assembly;
            var q = from t in commonPatternsAssembly.GetTypes()
                    where t.IsAbstract && t.IsSealed
                    from f in t.GetFields(BindingFlags.Public | BindingFlags.Static)
                    where f.FieldType == typeof(string)
                    select new PatternInfo(t.Name + "." + f.Name, (string)f.GetValue(null));

            var availablePatterns = q.ToArray();
            CmbPatterns.ItemsSource = availablePatterns;
        }

        private void CmbPatterns_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            EhlStop();

            var selectedPattern = (PatternInfo)CmbPatterns.SelectedItem;
            TextBox.Text = selectedPattern.Value;

            // ReSharper disable once LocalizableElement
            //Text = $"{_appName} ({selectedPattern.FullName})";

            var pattern = Pattern.Parse(selectedPattern.Value, _xRange, _yRange);
            _grid = new DD.Life.Grid(_xRange, _yRange, pattern);
        }

        private void EhlStart(object sender, RoutedEventArgs e)
        {

            TextBox.Text = _grid.ToString();

            _tmrReevaluation.Start();
        }

        private void EhlStop(object sender = null, RoutedEventArgs e = null)
        {
            _tmrReevaluation.Stop();
        }
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
}
