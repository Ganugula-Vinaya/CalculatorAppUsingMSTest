//Add 
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorAppUsingMSTest;


namespace MathsLibrary.MSTest
{
    [TestClass]
    public sealed class Test1
    {
        private Calculator calculator;//ref of a class
        [TestInitialize]
        public void TestInitialize()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        public void Add_ShouldReturnsMultiply()
        {
            int result = calculator.Multiply(2, 3);
            Assert.AreEqual(6, result);
            //assert is used to verify the result of the operation
        }
       
    }
}
