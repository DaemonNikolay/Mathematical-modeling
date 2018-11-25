using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MathModeliing
{
    public class TransportTask
    {
        private readonly List<int[]> table;

        public TransportTask(int[] a1, int[] a2, int[] a3, int[] a4, int[] needs)
        {
            if (a1 == null || a2 == null || a3 == null || a4 == null || needs == null)
            {
                throw new ArgumentNullException("Data for table exist null");
            }

            table = new List<int[]> {
                a1, a2, a3, a4, needs
            };
        }

        public double MethodDoublePreference() => MethodDoublePreference(table);

        public static double MethodDoublePreference(List<int[]> table)
        {
            if (table == null)
            {
                return double.MinValue;
            }

            var minLine = MinLine(table);
            var minColumn = MinColumn(table);

            return double.MinValue;
        }

        private static List<Cell> MinColumn(List<int[]> table)
        {
            if (table == null)
            {
                return null;
            }

            var minColumn = new List<Cell>();
            for (var i = 0; i < table.Count - 1; i++)
            {
                var column = new int[table[i].Length - 1];
                for (var j = 0; j < table[i].Length - 1; j++)
                {
                    column[j] = table[j][i];
                }

                var min = column.Min();
                minColumn.Add(new Cell(Array.IndexOf(column, min), i, min));
            }

            return minColumn;
        }

        private static List<Cell> MinLine(List<int[]> table)
        {
            if (table == null)
            {
                return null;
            }

            var minLine = new List<Cell>();
            for (var i = 0; i < table.Count - 1; i++)
            {
                var min = table[i].Min();
                minLine.Add(new Cell(i, Array.IndexOf(table[i], min), min));
            }

            return minLine;
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