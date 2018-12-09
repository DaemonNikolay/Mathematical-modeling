using System;
using System.Collections.Generic;
using System.Text;

namespace MathModelling
{
    public class TransportTask
    {
        private readonly List<List<Cell>> table;

        public TransportTask(List<List<Cell>> table)
        {
            if (table == null)
            {
                throw new ArgumentNullException(nameof(table));
            }

            this.table = table;
        }

        public double MethodDoublePreference()
        {
            return double.MinValue;
        }

        public static List<Cell> MinLines(List<List<Cell>> table)
        {
            var minimumsLines = new List<Cell>();

            foreach (var line in table)
            {
                var minLine = new Cell[line.Count - 1];
                var i = 0;

                foreach (var item in line)
                {
                    minLine[++i] = item;

                    var t = item;
                }
            }

            return minimumsLines;
        }

        public List<Cell> MinLines()
        {
            return MinLines(table);
        }

        public double MinColumn()
        {
            return double.MinValue;
        }

        public class Cell
        {
            public double PositionX { get; }
            public double PositionY { get; }
            public double GeneralValue { get; }
            public double NeedsValue { get; }
            public double ReservesValue { get; }
            public double Weight { get; }

            public Cell(double positionX, double positionY, double generalValue, double needsValue, double reservesValue, double weight = -1)
            {
                PositionX = positionX;
                PositionY = positionY;
                GeneralValue = generalValue;
                NeedsValue = needsValue;
                ReservesValue = reservesValue;
                Weight = weight;
            }
        }
    }
}
