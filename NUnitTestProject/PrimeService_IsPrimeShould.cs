namespace NUnitTestProject
{
    [TestFixture]
    public class Tests
    {
        private PrimeService _service;
        [SetUp]
        public void Setup()
        {
            _service = new PrimeService();
        }

        [Test]
        public void isPrime_Input1_ReturnFalse()
        {
            var result = _service.isPrime(1);
            Assert.IsFalse(result, "1 should not be prime");
        }
        [TestCase(-1)]
        [TestCase(1)]
        [TestCase(0)]
        public void isPrime_InputValueLess2_ReturnFalse(int value) 
        {
            var result = _service.isPrime(1);
            Assert.IsFalse(result,$"{value} should not be prime");

        }

    }
}