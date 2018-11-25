using MathModeliing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class TestTransportTask
    {
        private readonly TransportTask instance = new TransportTask(
            new int[5] { 7, 10, 11, 8, 200 },
            new int[5] { 6, 11, 15, 12, 300 },
            new int[5] { 4, 9, 6, 7, 400 },
            new int[5] { 11, 10, 7, 5, 100 },
            new int[5] { 350, 250, 160, 240, 1000 }
        );

        [TestMethod]
        public void MethodDoublePreference()
        {
            var expected = instance.MethodDoublePreference();

            Assert.AreEqual(expected: expected, actual: 0d);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorTableExistNull()
        {
            var expected = new TransportTask(
                new int[5] { 7, 10, 11, 8, 200 },
                new int[5] { 6, 11, 15, 12, 300 },
                null,
                new int[5] { 11, 10, 7, 5, 100 },
                new int[5] { 350, 250, 160, 240, 1000 }
            );
        }

        [TestMethod]
        public void MethodDoublePrefenceNull()
        {
            var expected = TransportTask.MethodDoublePreference(null);

            Assert.AreEqual(expected: expected, actual: double.MinValue);
        }
    }
}

