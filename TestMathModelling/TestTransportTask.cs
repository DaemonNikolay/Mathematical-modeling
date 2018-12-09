using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathModelling;
using System.Collections.Generic;

namespace TestMathModelling
{
    [TestClass]
    public class TestTransportTask
    {
        private static readonly List<List<TransportTask.Cell>> table = new List<List<TransportTask.Cell>>
        {
            new List<TransportTask.Cell>
            {
                new TransportTask.Cell(0, 0, 7, 350, 200),
                new TransportTask.Cell(1, 0, 10, 250, 200),
                new TransportTask.Cell(2, 0, 11, 160, 200),
                new TransportTask.Cell(3, 0, 8, 240, 200)
            },
            new List<TransportTask.Cell>
            {
                new TransportTask.Cell(0, 1, 6, 350, 300),
                new TransportTask.Cell(1, 1, 11, 250, 300),
                new TransportTask.Cell(2, 1, 16, 160, 300),
                new TransportTask.Cell(3, 1, 121, 240, 300)
            },
            new List<TransportTask.Cell>
            {
                new TransportTask.Cell(0, 2, 4, 350, 400),
                new TransportTask.Cell(1, 2, 9, 250, 400),
                new TransportTask.Cell(2, 2, 6, 160, 400),
                new TransportTask.Cell(3, 2, 7, 240, 100)
            },
            new List<TransportTask.Cell>
            {
                new TransportTask.Cell(0, 3, 11, 350, 100),
                new TransportTask.Cell(1, 3, 10, 250, 100),
                new TransportTask.Cell(2, 3, 7, 160, 100),
                new TransportTask.Cell(3, 3, 5, 240, 100)
            },
        };

        private readonly TransportTask instance = new TransportTask(table);

        [TestMethod]
        public void MethodDoublePreference()
        {
            var actual = instance.MethodDoublePreference();

            Assert.AreEqual(actual: actual, expected: 0);
        }

        [TestMethod]
        public void MinLine()
        {
            var actual = instance.MinLines();

            Assert.AreEqual(actual: actual, expected: 0);
        }
    }
}