using log4net.Core;
using log4net.Filter;
using log4net.Layout;

namespace DD.Life.Test.Utils
{
    /// <remarks>
    /// Since NUnit 3, output of TraceAppender doesn't end up in ReSharper test runner output.
    /// </remarks>
    public class TestAppender : log4net.Appender.ConsoleAppender
    {
        public TestAppender()
        {
            Threshold = Level.Debug;

            SetLayout();
            AddFilters();
        }

        private void SetLayout()
        {
            Layout = new PatternLayout("%message%newline");
        }

        private void AddFilters()
        {
        }
    }
}