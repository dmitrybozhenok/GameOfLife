using System;
using System.Collections.Generic;
using System.Linq;

namespace DD.Life
{
    public class Pattern
    {
        private readonly int _width;
        private readonly int _height;

        public ICollection<Point> Points { get; }

        public Pattern(ICollection<Point> points)
        {
            if (points == null)
                throw new ArgumentNullException(nameof(points));
            if (points.Count == 0)
                throw new ArgumentException("No points specified", nameof(points));

            Points = new HashSet<Point>(points);
            CalculateSize(out _width, out _height);
        }

        private void CalculateSize(out int width, out int height)
        {
            width = 0;
            height = 0;

            foreach (var point in Points)
            {
                if (point.X >= width)
                    width++;
                if (point.Y >= height)
                    height++;
            }
        }

        private static readonly string[] NewLineSeparators = new[] { Environment.NewLine };

        public static Pattern Parse(string pattern, int xRange, int yRange, Point offset = default(Point))
        {
            var points = new List<Point>();

            var y = 0;
            var lines = pattern.Split(NewLineSeparators, StringSplitOptions.RemoveEmptyEntries);
            for (var i = lines.Length - 1; i >= 0; i--)
            {
                var line = lines[i];
                var x = 0;
                foreach (var c in line)
                {
                    if (c != ' ')
                        points.Add(new Point(x + offset.X, y + offset.Y, xRange, yRange));
                    x++;
                }
                y++;
            }

            return new Pattern(points);
        }

        public override string ToString()
        {
            return $"";
        }
    }
}