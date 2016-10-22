using NUnit.Framework;

namespace DD.Life.Test
{
    [TestFixture]
    public class PointTest
    {
        [Test]
        public void EqualShouldBeEqual()
        {
            var c1 = new Point(3, 2);
            var c2 = new Point(3, 2);

            Assert.AreEqual(c1, c2);
        }

        [Test]
        public void FlippedShouldBeNotEqual()
        {
            var c1 = new Point(3, 2);
            var c2 = new Point(2, 3);

            Assert.AreNotEqual(c1, c2);
        }

        [Test]
        public void NotEqualShouldBeNotEqual()
        {
            var c1 = new Point(2, 3);
            var c2 = new Point(2, 4);

            Assert.AreNotEqual(c1, c2);
        }
    }
}