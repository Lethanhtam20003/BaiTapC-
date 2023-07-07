namespace NUnitTestDemo

{
    [TestFixture]
    public class PrimeService_IsPrimeShould 
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

        [TestCase(3)]
        public void isPrime_InputValueLess2_ReturnException(int value)
        {
            Assert.Throws<NotImplementedException>(()=> { _service.isPrime(value); });
            //var result = _service.isPrime(value);
            //Assert.IsFalse(result, $"{value} should not be prime");

        }

        [Test]
        public void stringMethodTest_ReturnTrue ()
        {
            // arrange : setup data 
            string input = null;
            bool expected = true ;

            // action : 
            var result = string.IsNullOrEmpty(input) ;

            // asser
            Assert.That(expected,Is.EqualTo( result)) ;
        }
    }
    
}