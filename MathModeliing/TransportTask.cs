using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MathModeliing
{
    public class TransportTask
    {
        private List<int[]> table;

        public TransportTask(int[] a1, int[] a2, int[] a3, int[] a4, int[] needs)
        {
            table = new List<int[]> {
                a1, a2, a3, a4, needs
            };
        }

        public double MethodDoublePreference()
        {
            var table = this.table;

            var minLine = new List<int>();
            foreach (var value in table)
            {
                minLine.Add(value.Min());
            }
            minLine.Remove(minLine[minLine.Count - 1]);

            var minColumn = new List<int>();
            for (var i = 0; i < table.Count - 1; i++)
            {
                var column = new List<int>();
                for (var j = 0; j < table[0].Length - 1; j++)
                {
                    column.Add(table[j][i]);
                }

                minColumn.Add(column.Min());
            }

            var test = minLine;

            return double.MinValue;
        }

        public double MethodPotential()
        {
            return double.MinValue;
        }

        private class Cell
        {
            public int PostitionX { get; }
            public int PostitionY { get; }
            public int Value { get; set; }

            public Cell(int postitionX, int postitionY, int value)
            {
                PostitionX = postitionX;
                PostitionY = postitionY;
                Value = value;
            }
        }
    }
}