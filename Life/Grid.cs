using System;
using System.Collections.Generic;
using System.Text;

namespace DD.Life
{
    public class Grid
    {
        private const int UnderPopulationThreshold = 2;
        private const int OverPopulationThreshold = 3;
        private const int RePopulationThreshold = 3;

        private readonly int _width;
        private readonly int _height;

        private Cell[,] _cells;

        public Grid(int width, int height, Pattern seed = null)
        {
            _width = width;
            _height = height;
            _cells = new Cell[width, height];

            for (var x = 0; x < width; x++)
                for (var y = 0; y < height; y++)
                {
                    var point = new Point(x, y);
                    var cell = new Cell(point);
                    if (seed != null && seed.Points.Contains(point))
                        cell.Revive();

                    _cells[x, y] = cell;
                }
        }

        private static readonly int[] NeighborDeltas = { -1, 0, 1 };

        public void Reevaluate()
        {
            var reevaluatedCells = (Cell[,])_cells.Clone();

            for (var x = 0; x < _width; x++)
                for (var y = 0; y < _height; y++)
                {
                    var cell = _cells[x, y];

                    var aliveNeighbors = 0;

                    foreach (var dx in NeighborDeltas)
                        foreach (var dy in NeighborDeltas)
                        {
                            if (dx == 0 && dy == 0)
                                continue;

                            var nx = (x + dx).Modulo(_width);
                            var ny = (y + dy).Modulo(_height);
                            var neighbor = _cells[nx, ny];
                            if (neighbor.Alive)
                                aliveNeighbors++;
                        }

                    var reevaluatedCell = reevaluatedCells[x, y];

                    if (cell.Alive)
                    {
                        if (aliveNeighbors < UnderPopulationThreshold || aliveNeighbors > OverPopulationThreshold)
                        {
                            // Any live cell with fewer than two live neighbours dies, as if caused by under-population.
                            // Any live cell with more than three live neighbours dies, as if by over - population.
                            reevaluatedCell.Kill();
                        }
                        else
                        {
                            // Any live cell with two or three live neighbours lives on to the next generation.
                        }
                    }
                    else
                    {
                        if (aliveNeighbors == RePopulationThreshold)
                        {
                            // Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.
                            reevaluatedCell.Revive();
                        }
                    }

                    reevaluatedCells[x, y] = reevaluatedCell;
                }

            _cells = reevaluatedCells;
        }

        public Pattern GetPopulationPattern()
        {
            var ret = new List<Point>();

            for (var x = 0; x < _width; x++)
                for (var y = 0; y < _height; y++)
                {
                    var cell = _cells[x, y];
                    if (cell.Alive)
                        ret.Add(cell.Point);
                }

            return new Pattern(ret);
        }

        public override string ToString()
        {
            const char horizontal = '─';
            const char vertical = '│';
            const char nw = '┌';
            const char ne = '┐';
            const char sw = '└';
            const char se = '┘';

            var sb = new StringBuilder();
            sb.Append(nw).Append(horizontal, _width).Append(ne).AppendLine();

            for (var y = _height - 1; y >= 0; y--)
            {
                sb.Append(vertical);
                for (var x = 0; x < _width; x++)
                {
                    var cell = _cells[x, y];
                    sb.Append(cell);
                }
                sb.Append(vertical).AppendLine();
            }

            sb.Append(sw).Append(horizontal, _width).Append(se).AppendLine();

            return sb.ToString();
        }
    }
}