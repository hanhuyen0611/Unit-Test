using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculatorrrr;
namespace CalculatorTester
{
    [TestClass]
    public class UnitTest1
    {
        private Calculation c;
        public TestContext TestContext { get; set; }
        [TestInitialize] //thiết lập dữ liệu dùng chung
        public void SetUp()
        {
            c = new Calculation(10, 5);
        }
        [TestMethod]
        public void TestAddOperator()
        {
            int expected, actual;
            expected = 10;
            actual = c.Execture("+");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestSubOperator()
        {
            int expected, actual;
            expected = 15;
            actual = c.Execture("-");
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestMulOperator()
        {
            int expected, actual;
            expected = 15;
            actual = c.Execture("*");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestDivOperator()
        {
            int expected, actual;
            expected = 15;
            actual = c.Execture("/");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
@".\Data\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        public void TestWithDataSource()
        {
            Calculation c;
            int a, b, expected;
            a = int.Parse(TestContext.DataRow[0].ToString());
            b = int.Parse(TestContext.DataRow[1].ToString());
            expected = int.Parse(TestContext.DataRow[2].ToString());
            c = new Calculation(a,b);
            Assert.AreEqual(expected, c.Execture("+"));
        }
    }
}
