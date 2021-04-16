using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhysicsFormulas.Mechanics.Energy;

namespace PhysicsFormulasUnitTests.Mechanics
{
    [TestClass]
    public class EnergyTests
    {
        [TestMethod]
        public void PowerTest()
        {
            var dW = 21;
            var dt = 7;
            var p = 3;

            Assert.AreEqual(p, Power.GetPower(dW, dt));
            Assert.AreEqual(dW, Power.GetDeltaWork(p, dt));
            Assert.AreEqual(dt, Power.GetDeltaTime(p, dW));
        }
    }
}