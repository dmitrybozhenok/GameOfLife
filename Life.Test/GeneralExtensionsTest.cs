using NUnit.Framework;

namespace DD.Life.Test
{
    [TestFixture]
    public class GeneralExtensionsTest
    {
        [TestCase(7, 3, ExpectedResult = 1)]
        [TestCase(8, 3, ExpectedResult = 2)]
        [TestCase(-7, 3, ExpectedResult = 2)]
        [TestCase(-7, -7, ExpectedResult = 0)]
        [TestCase(-7, 7, ExpectedResult = 0)]
        public int ModuloShouldWork(int divident, int divisor)
        {
            return divident.Modulo(divisor);
        }
    }
}