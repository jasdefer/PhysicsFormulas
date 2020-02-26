using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhysicsFormulas.Mechanics;
using System;

namespace PhysicsFormulasUnitTests.MechanicsUnitTests
{
    [TestClass]
    public class DurationUnitTests
    {
        [TestMethod]
        public void ZeroAccelerationZeroVelocity()
        {
            Assert.ThrowsException<DivideByZeroException>(() => Duration.UniformAcceleration(0, 1, 0));
        }
    }
}