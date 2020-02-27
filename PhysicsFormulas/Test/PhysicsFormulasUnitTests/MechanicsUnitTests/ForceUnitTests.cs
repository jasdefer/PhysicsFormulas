using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhysicsFormulas.Mechanics;
using System;

namespace PhysicsFormulasUnitTests.MechanicsUnitTests
{
    [TestClass]
    public class ForceUnitTests
    {
        [TestMethod]
        public void AirResistance()
        {
            var f = Force.AirResistance(3, 7, 13, 2);
            Assert.AreEqual(3549, f);
        }

        [TestMethod]
        public void AccelerationForce()
        {
            var f = Force.AccelerationForce(5,13,3,2);
            Assert.AreEqual(69, f);
        }

        [TestMethod]
        public void DownHillForceOnPlane()
        {
            var f = Force.DownHillForce(10,0,9.81);
            Assert.AreEqual(0, f);
        }

        [TestMethod]
        public void DownHillForce()
        {
            var f = Force.DownHillForce(10, Math.PI/2, 9.81);
            Assert.AreEqual(98.1, f, 0.000000001);
        }

        [TestMethod]
        public void RollingResistance()
        {
            var f = Force.RollingResistance(9, Math.PI/4, 4, 9.81);
            Assert.AreEqual(249.721830844, f, 0.000000001);
        }
    }
}