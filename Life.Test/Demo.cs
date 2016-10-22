using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace DD.Life.Test
{
    [TestFixture]
    public class Demo
    {
        private static readonly Common.Logging.ILog Log = Common.Logging.LogManager.GetLogger<Demo>();

        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(-2, -2)]
        public void Blinker(int dx, int dy)
        {
            const int width = 5;
            const int height = 5;
            var blinker = GetBlinker(dx, dy, width, height);
            Execute(width, height, blinker, 4);
        }

        private static Pattern GetBlinker(int dx, int dy, int width, int height)
        {
            return Pattern.Parse(@"***", width, height, new Point(dx, dy));
        }

        [TestCase(0, 0)]
        [TestCase(-2, -2)]
        [TestCase(2, 2)]
        public void Boat(int dx, int dy)
        {
            const int height = 5;
            const int width = 5;
            var seed = GetBoat(dx, dy, width, height);
            Execute(height, width, seed, 3);
        }

        private static Pattern GetBoat(int dx, int dy, int width, int height)
        {
            return Pattern.Parse(@"
**
* *
 *", width, height, new Point(dx, dy));
        }

        [Test]
        public void Glider()
        {
            const int height = 8;
            const int width = 8;
            var seed = GetGlider(0, 0, width, height);
            Execute(height, width, seed, 10);
        }

        private static Pattern GetGlider(int dx, int dy, int width, int height)
        {
            return Pattern.Parse(@"
  *
* *
 **", width, height, new Point(dx, dy));
        }

        private static void Execute(int width, int height, Pattern seed, int iterations)
        {
            var grid = new Grid(width, height, seed);

            Log.Info(grid);

            for (var i = 0; i < iterations; i++)
            {
                grid.Reevaluate();

                Log.Info(grid);
            }
        }
    }
}