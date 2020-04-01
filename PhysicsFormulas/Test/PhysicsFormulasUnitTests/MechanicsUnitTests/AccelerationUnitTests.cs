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
            var a = Acceleration.FromDisplacementOverTime(80, 10, 3);
            Assert.AreEqual(1, a);
        }

        [TestMethod]
        public void DivideByZero()
        {
            Assert.ThrowsException<DivideByZeroException>(() => Acceleration.FromDisplacementOverTime(1,0,1));
        }

        [TestMethod]
        public void FromVelocityChangeDivideByZero()
        {
            Assert.ThrowsException<DivideByZeroException>(() => Acceleration.FromVelocityChange(1, 0));
        }

        [TestMethod]
        public void FromVelocityChange()
        {
            var a = Acceleration.FromVelocityChange(8, 2);
            Assert.AreEqual(4, a);
        }
    }
}