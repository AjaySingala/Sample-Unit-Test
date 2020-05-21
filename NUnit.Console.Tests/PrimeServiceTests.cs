using NUnit.Framework;
using SampleConsoleAppWithUnitTest;

namespace NUnit.Console.Tests
{
    [TestFixture]
    public class PrimeServiceTests
    {
        private PrimeService _primeService;

        [SetUp]
        public void SetUp()
        {
            _primeService = new PrimeService();
        }

        #region Sample_FirstTest

        [Test]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            var result = _primeService.IsPrime(1);

            Assert.IsFalse(result, "1 should not be prime");
        }

        #endregion
        
        #region Sample_TestCode
        
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.IsFalse(result, $"{value} should not be prime");
        }

        [TestCase(2)]
        [TestCase(3)]
        [TestCase(5)]
        [TestCase(7)]
        public void IsPrime_PrimesLessThan10_ReturnTrue(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.True(result, $"{value} should be prime");
        }

        [TestCase(4)]
        [TestCase(6)]
        [TestCase(8)]
        [TestCase(9)]
        public void IsPrime_NonPrimesLessThan10_ReturnFalse(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.False(result, $"{value} should not be prime");
        }
        #endregion
    }
}