using MathModeliing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
        public void MethodPotential()
        {
            var expected = instance.MethodPotential();

            Assert.AreEqual(expected: expected, actual: 0d);
        }

        [TestMethod]
        public void MethodDoublePreference()
        {
            var expected = instance.MethodDoublePreference();

            Assert.AreEqual(expected: expected, actual: 0d);
        }
    }
}

