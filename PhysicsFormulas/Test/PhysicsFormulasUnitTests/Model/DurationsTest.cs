namespace PhysicsFormulasUnitTests.Model
{
    [TestClass]
    public class DurationsTest
    {
        [TestMethod]
        public void Constructor()
        {
            var durations = new Durations(1, 2);

            Assert.AreEqual(1, durations.Duration1);
            Assert.AreEqual(2, durations.Duration2);
        }

        [TestMethod]
        public void SortedConstructor()
        {
            var durations = new Durations(2, 1);

            Assert.AreEqual(1, durations.Duration1);
            Assert.AreEqual(2, durations.Duration2);
        }

        [TestMethod]
        public void GetSmallestPositiveDuration()
        {
            var durations = new Durations(2, 1);

            Assert.AreEqual(1, durations.GetSmallestPositiveDuration());
        }

        [TestMethod]
        public void GetSmallestPositiveDurationWithNegative()
        {
            var durations = new Durations(2, -1);

            Assert.AreEqual(2, durations.GetSmallestPositiveDuration());
        }

        [TestMethod]
        public void GetSmallestPositiveDurationException()
        {
            var durations = new Durations(-2, -1);

            Assert.ThrowsException<NegativeValueException>(() => durations.GetSmallestPositiveDuration());
        }
    }
}