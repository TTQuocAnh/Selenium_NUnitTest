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
        
        








        /*
        [Test]
        public void OnePlusOneEqualTwo()
        {
            Assert.AreEqual(2, _cal.Add(1, 1));
        }

        [Test]
        public void TwoPlusTwoEqualFour()
        {
            Assert.AreEqual(4, _cal.Add(2, 2));
        }

        [Test]
        public void FourPlusOneEqualFive()
        {
            Assert.AreEqual(5, _cal.Add(4, 1));
        }
        */

        //Test HCN
        /*
        [Test]
        public void TestHCN1()
        {
            Assert.AreEqual(100, _cal.DienTichHinhChuNhat(5, 15));
        }
        [Test]
        public void TestHCN2()
        {
            Assert.AreEqual(200, _cal.DienTichHinhChuNhat(10, 20));
        }
        [Test]
        public void TestHCN3()
        {
            //Assert.AreEqual(350, _cal.DienTichHinhChuNhat(35, 10));
            Assert.That(350, Is.EqualTo(_cal.DienTichHinhChuNhat(35, 10))); ;
        }
        [Test]
        public void TestHCN4()
        {
            Assert.AreEqual(225, _cal.DienTichHinhChuNhat(22, 20));
        }
        */
        /*
        //test hcn 2
        [TestCase(10, 20, 200)]
        [TestCase(15, 25, 300)]
        [TestCase(15, 20, 300)]
        [TestCase(20, 20, 300)]

        //test hcn 2
        public void CheckDienTichHcn(double a, double b, double c)
        {
            Calculator calculator = new Calculator();
            double kq = calculator.DienTichHinhChuNhat(a, b);
            Assert.That(kq, Is.EqualTo(c)); ;
        }
        */
    }
}