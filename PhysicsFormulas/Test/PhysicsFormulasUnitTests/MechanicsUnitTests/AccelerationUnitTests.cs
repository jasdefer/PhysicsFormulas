using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhysicsFormulas.Mechanics;
using System;

namespace PhysicsFormulasUnitTests.MechanicsUnitTests
{
    [TestClass]
    public class AccelerationUnitTests
    {
        [TestMethod]
        public void UniformAcceleration()
        {
            var a = Acceleration.UniformAcceleration(80, 10, 3);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void DivideByZero()
        {
            Assert.ThrowsException<DivideByZeroException>(() => Acceleration.UniformAcceleration(1,0,1));
        }
    }
}