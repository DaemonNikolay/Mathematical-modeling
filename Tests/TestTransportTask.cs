using MathModeliing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class TestTransportTask
    {
        private readonly TransportTask instance = new TransportTask();

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

