using PhysicsFormulas.Mechanics.Translation;

namespace PhysicsFormulasUnitTests.Mechanics
{
    [TestClass]
    public class TranslationTest
    {
        [TestMethod]
        public void SteadyMotionTest()
        {
            var t = 5;
            var s = 35;
            var v = 7;

            Assert.AreEqual(t, SteadyMotion.GetDuration(s, v));
            Assert.AreEqual(s, SteadyMotion.GetDistance(v, t));
            Assert.AreEqual(v, SteadyMotion.GetVelocity(s, t));
        }

        [TestMethod]
        public void UniformAccelerationTest1()
        {
            var s = 32;
            var t1 = 4;
            var t2 = 16;
            var v0 = 10;
            var a = -1;
            var dv = -4; //at t1

            Assert.AreEqual(s, UniformAcceleration.GetDistance(a, t1, v0));
            Assert.AreEqual(s, UniformAcceleration.GetDistance(a, t2, v0));

            var durations = UniformAcceleration.GetDuration(s, a, v0);
            Assert.AreEqual(t1, durations.Duration1);
            Assert.AreEqual(t2, durations.Duration2);

            Assert.AreEqual(v0, UniformAcceleration.GetStartVelocity(s, a, t1));
            Assert.AreEqual(v0, UniformAcceleration.GetStartVelocity(s, a, t2));

            Assert.AreEqual(a, UniformAcceleration.GetAcceleration(s, t1, v0));
            Assert.AreEqual(a, UniformAcceleration.GetAcceleration(s, t2, v0));

            Assert.AreEqual(a, UniformAcceleration.GetAcceleration(dv, t1));
            Assert.AreEqual(dv, UniformAcceleration.GetDeltaVelocity(a, t1));
            Assert.AreEqual(t1, UniformAcceleration.GetDeltaDuration(a, dv));
        }

        [TestMethod]
        public void UniformAccelerationTest2()
        {
            var s = 51;
            var v0 = 10;
            var a = -1;

            Assert.ThrowsException<NegativeValueException>(() => UniformAcceleration.GetDuration(s, a, v0));
        }

        [TestMethod]
        public void UniformAccelerationTest3()
        {
            var s = 3;
            var v0 = 1;
            var a = 0;

            var durations = UniformAcceleration.GetDuration(s, a, v0);
            Assert.AreEqual(3, durations.Duration2, 0.01);
            Assert.AreEqual(3, durations.Duration1, 0.01);
        }
    }
}