using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            var s = 1;
            var t = 4;
            var v0 = 10;
            var a = -1;

            Assert.AreEqual(, UniformAcceleration.GetAcceleration());
        }
    }
}