using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhysicsFormulas.Mechanics;
using System;

namespace PhysicsFormulasUnitTests.MechanicsUnitTests
{
    [TestClass]
    public class DisplacementUnitTests
    {
        private static (double t, double v0, double s0, double a) GetRandomValues(Random rnd)
        {
            var t = rnd.NextDouble() * 3600;
            var v0 = (rnd.NextDouble()-0.5) * 20;
            var s0 = (rnd.NextDouble() - 0.5) * 1000;
            var a = (rnd.NextDouble()-0.5)*5;
            return (t, v0, s0, a);
        }

        [TestMethod]
        public void UniformAcceleration()
        {
            var s = Displacement.UniformAcceleration(3, 10, 1, 2);
            Assert.AreEqual(82, s);
        }

        [TestMethod]
        public void SteadyMotion()
        {
            var s = Displacement.SteadyMotion(3, 10, 2);
            Assert.AreEqual(32, s);
        }

        [TestMethod]
        public void CompareUniformAccelerationAndSteadyMotion()
        {
            var rnd = new Random(1);
            for (int i = 0; i < 1000; i++)
            {
                (var t, var v0, var s0, var a) = GetRandomValues(rnd);
                var s1 = Displacement.UniformAcceleration(v0,t,0,s0);
                var s2 = Displacement.SteadyMotion(v0, t, s0);
                Assert.AreEqual(s1, s2);
            }
        }

        [TestMethod]
        public void NoMovementNoAcceleration()
        {
            var rnd = new Random(1);
            for (int i = 0; i < 1000; i++)
            {
                (var t, var v0, var s0, var a) = GetRandomValues(rnd);
                var s1 = Displacement.UniformAcceleration(0, t, 0, s0);
                Assert.AreEqual(s1, s0);
            }
        }

        [TestMethod]
        public void NoMovement()
        {
            var rnd = new Random(1);
            for (int i = 0; i < 1000; i++)
            {
                (var t, var v0, var s0, var a) = GetRandomValues(rnd);
                var s1 = Displacement.SteadyMotion(0, t, s0);
                Assert.AreEqual(s1, s0);
            }
        }

        
    }
}