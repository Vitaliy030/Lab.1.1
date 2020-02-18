using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 3;
            int b = 4;
            double c = 5;
            double result = ConsoleApp2.Program.Example1(a, b);
            Assert.AreEqual(5, result);
            double result1 = ConsoleApp2.Program.Example2(a, b, result);
            Assert.AreEqual(12, result1);
        }
    }
}
