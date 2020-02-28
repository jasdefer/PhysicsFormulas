using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhysicsFormulas.Mechanics;
using System;

namespace PhysicsFormulasUnitTests.MechanicsUnitTests
{
    [TestClass]
    public class DurationUnitTests
    {
        private static (double t, double v0, double a) GetRandomValues(Random rnd)
        {
            var t = rnd.NextDouble() * 3600;
            var v0 = (rnd.NextDouble() - 0.5) * 20;
            var a = (rnd.NextDouble() - 0.5) * 5;
            return (t, v0, a);
        }

        [TestMethod]
        public void UniformAccelerationZeroAccelerationZeroVelocity()
        {
            Assert.ThrowsException<DivideByZeroException>(() => Duration.UniformAcceleration(0, 1, 0));
        }

        [TestMethod]
        public void SteadyMovementZeroVelocity()
        {
            Assert.ThrowsException<DivideByZeroException>(() => Duration.SteadyMovement(0, 1));
        }

        [TestMethod]
        public void SteadyMovementZeroVelocityZeroDistance()
        {
            var t = Duration.SteadyMovement(0, 0);
            Assert.AreEqual(0, t);
        }

        [TestMethod]
        public void SteadyMovement()
        {
            var t = Duration.SteadyMovement(1, 2);
            Assert.AreEqual(2, t);
        }

        [TestMethod]
        public void GetSmallestPositiveTimeBothNegative()
        {
            Assert.ThrowsException<Exception>(() => Duration.GetSmallestPositiveTime(-1, -1));
        }

        [TestMethod]
        public void GetSmallestPositiveTimeT1Negative()
        {
            var t = Duration.GetSmallestPositiveTime(-1, 2);
            Assert.AreEqual(2, t);
        }

        [TestMethod]
        public void GetSmallestPositiveTimeT2Negative()
        {
            var t = Duration.GetSmallestPositiveTime(2, -1);
            Assert.AreEqual(2, t);
        }

        [TestMethod]
        public void GetSmallestPositiveTime()
        {
            var t = Duration.GetSmallestPositiveTime(2, 3);
            Assert.AreEqual(2, t);
        }

        [TestMethod]
        public void Monkey()
        {
            var rnd = new Random(1);
            for (int i = 0; i < 1000; i++)
            {
                (var t, var v0, var a) = GetRandomValues(rnd);
                var s = Displacement.UniformAcceleration(v0,t,a);
                (var t1, var t2) = Duration.UniformAcceleration(v0, s, a);
                var s1 = Displacement.UniformAcceleration(v0, t1, a);
                var s2 = Displacement.UniformAcceleration(v0, t2, a);
                //Either s1 or s2 should be equal to s
                //So either s-s1 or s-s2 should be zero
                //If s is not equal to s1 or s2, the product is never 0
                Assert.AreEqual(0, (s-s1)*(s-s2),0.000000000001, "Calculating the duration and calculating the distance do not return the same values.");
            }
        }
    }
}