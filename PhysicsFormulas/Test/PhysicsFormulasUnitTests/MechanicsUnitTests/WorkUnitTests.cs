using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhysicsFormulas.Mechanics;

namespace PhysicsFormulasUnitTests.MechanicsUnitTests
{
    [TestClass]
    public class WorkUnitTests
    {
        [TestMethod]
        public void ConstantForce()
        {
            var w = Work.ConstantForce(2, 3);
            Assert.AreEqual(6, w);
        }
    }
}