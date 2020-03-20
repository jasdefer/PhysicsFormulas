using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhysicsFormulas.Mechanics;
using System;

namespace PhysicsFormulasUnitTests.MechanicsUnitTests
{
    [TestClass]
    public class VelocityUnitTests
    {
        private static (double t, double s, double a) GetRandomValues(Random rnd)
        {
            var t = rnd.NextDouble() * 3600;
            var s0 = (rnd.NextDouble() - 0.5) * 1000;
            var a = (rnd.NextDouble() - 0.5) * 5;
            return (t, s0, a);
        }

        [TestMethod]
        public void UniformAcceleration()
        {
            var v = Velocity.UniformAcceleration(80,10,1);
            Assert.AreEqual(3, v);
        }

        [TestMethod]
        public void SteadyMotion()
        {
            var v = Velocity.SteadyMotion(30, 10);
            Assert.AreEqual(3, v);
        }

        [TestMethod]
        public void CompareUniformAccelerationAndSteadyMotion()
        {
            var rnd = new Random(1);
            for (int i = 0; i < 1000; i++)
            {
                (var t, var s0, var a) = GetRandomValues(rnd);
                if (t == 0)
                {
                    t = 1;
                }
                var v1 = Velocity.UniformAcceleration(s0, t, 0);
                var v2 = Velocity.SteadyMotion(s0, t);
                Assert.AreEqual(v1, v2);
            }
        }

        [TestMethod]
        public void DivideByZero()
        {
            Assert.ThrowsException<DivideByZeroException>(() => Velocity.SteadyMotion(1, 0));
            Assert.ThrowsException<DivideByZeroException>(() => Velocity.UniformAcceleration(2, 0, 1));
        }
    }
}