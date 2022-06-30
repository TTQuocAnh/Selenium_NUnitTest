using Nunit_test;

namespace Nunit_test_sele
{
    [TestFixture]
    public class Tests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }
        // ** Test LAB **//
        [Test]
        // Date time checker
        [TestCase(31, 1, 2020, true)]
        [TestCase(28, 2, 2021, true)]
        [TestCase(28, 2, 2019, true)]
        [TestCase(29, 4, 2010, true)]
        [TestCase(29, 8, 2016, true)]
        [TestCase(31, 7, 2021, true)]
        [TestCase(30, 2, 2020, true)]
        [TestCase(30, 6, 2019, true)]
        [TestCase(30, 6, 2019, true)]
        [TestCase(28, 11, 2016, true)]
        [TestCase(30, 9, 2019, true)]
        [TestCase(31, 5, 2021, true)]
        [TestCase(31, 5, 2021, true)]
        [TestCase(31, 2, 2008, true)]
        [TestCase(31, 2, 2008, true)]
        [TestCase(31, 8, 2020, true)]
        [TestCase(30, 6, 2019, true)]
        [TestCase(30, 2, 2016, true)]

        public void CheckDateTimeTest(int day, int month, int year, bool flag)
        {
            bool kq = calculator.CheckNgay(day, month, year);
            Assert.That(kq, Is.EqualTo(flag));
        }
        
       
    }
}
