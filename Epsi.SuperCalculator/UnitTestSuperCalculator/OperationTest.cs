using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;

namespace UnitTestSuperCalculator
{
    [TestClass]
    public class OperationTest
    {
        [TestMethod]
        public void TestSoustraction()
        {
            var operation = new Operation();

           
            int resultat = operation.getResult("10-5");
            int excepted = 5;

            Check.That(resultat).Equals(excepted);
        }
    }
}
