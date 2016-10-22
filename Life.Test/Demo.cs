using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using static DD.CommonPatterns.StillLifes;
using static DD.CommonPatterns.Oscillators;
using static DD.CommonPatterns.Spaceships;

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
            var blinker = Pattern.Parse(BlinkerPattern, width, height, new Point(dx, dy));
            Execute(width, height, blinker, 4);
        }

        [TestCase(0, 0)]
        [TestCase(-2, -2)]
        [TestCase(2, 2)]
        public void Boat(int dx, int dy)
        {
            const int height = 5;
            const int width = 5;
            var seed = Pattern.Parse(BoatPattern, width, height, new Point(dx, dy));
            Execute(height, width, seed, 3);
        }

        [Test]
        public void Glider()
        {
            const int height = 8;
            const int width = 8;
            var seed = Pattern.Parse(GliderPattern, width, height, new Point(0, 0));
            Execute(height, width, seed, 10);
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