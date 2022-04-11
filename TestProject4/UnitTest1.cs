using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestProject4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrage 
            string input = "2+2*2";
            double? expected = 6;

            //act
            MyCalc c = new MyCalc();
            double? actual = c.ParseExpression(input);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
