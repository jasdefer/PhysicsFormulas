using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhysicsFormulas.Mechanics;

namespace PhysicsFormulasUnitTests.MechanicsUnitTests
{
    [TestClass]
    public class PowerUnitTest
    {
        [TestMethod]
        public void FromWork()
        {
            var p = Power.FromWork(3, 2);
            Assert.AreEqual(1.5, p);
        }   
    }
}