

namespace CShapeTutoriol
{
    public class TestExercise_3
    {
        Exercise_3 cls;
        private int[] inputArr;

        private int[] actualMatrix;
        private int actualNumber;
        private bool actualBool;

        private int[] expectedArr;
        private int expectedNumber;
        private bool expectedBool;

        [SetUp]
        public void Setup()
        {
            //cls = new ();

            inputArr = new int[5] { 5, -2, 1, -4, 3 };

            actualMatrix = cls.Exercise127(inputArr);
            expectedArr = new int[5] { 1, 2, 3, 4, 5 };

        }

        [Test]
        public void Exercise122_test()
        {
            actualNumber = cls.Exercise122(inputArr);
            expectedNumber = 5;
            Assert.That(actualNumber, Is.EqualTo(expectedNumber));

        }

        [Test]
        public void Exercise123_test()
        {
            actualNumber = cls.Exercise123(inputArr);
            expectedNumber = 3;
            Assert.That(actualNumber, Is.EqualTo(expectedNumber));
        }

        [Test]
        public void Exercise124_test()
        {
            actualBool = cls.Exercise124(inputArr);
            expectedBool = true;
            Assert.That(actualNumber, Is.EqualTo(expectedNumber));
        }

        [Test]
        public void Exercise125_test()
        {
            actualNumber = cls.Exercise125(inputArr);
            expectedNumber = 2;
            Assert.That(actualNumber, Is.EqualTo(expectedNumber));
        }

        [Test]
        public void Exercise126_test()
        {
            actualNumber = cls.Exercise126(inputArr);
            expectedNumber = -6;
            Assert.That(actualNumber, Is.EqualTo(expectedNumber));
        }

        [Test]
        public void Exercise127_test()
        {
            actualMatrix = cls.Exercise127(inputArr);
            expectedArr = new int[5] { 1, 2, 3, 4, 5 };

            Assert.That(actualNumber, Is.EqualTo(expectedNumber));
        }

        [Test]
        public void isPrimeTest()
        {
            actualBool = cls.isPrime(3);
            expectedBool = true;
            Assert.That(actualBool, Is.EqualTo(expectedBool));
        }

        [Test]
        public void encrypytion_test()
        {

            String inputString = "geeksforgreeks";
            String expectedString = "miiuzkcimiiuz";
            //                         miiuzkzzmziiuz
            String actualString = cls.encryption(inputString);

            Assert.That(actualString, Is.EqualTo(expectedString));




        }
    }
}