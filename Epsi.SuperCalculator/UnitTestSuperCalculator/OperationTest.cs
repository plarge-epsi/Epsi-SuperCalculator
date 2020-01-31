using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;

namespace UnitTestSuperCalculator
{
    [TestClass]
    public class OperationTest
    {
        /// <summary>
        /// Vérifie que l'on renvoie 4 quand le nombre1 vaut 1 et nombre2 vaut 3
        /// </summary>
        [TestMethod]
        public void TestSoustraction()
        {
            var operation = new Operation();


            int resultat = operation.getResult("10-5");
            int excepted = 5;

            Check.That(resultat).Equals(excepted);
            public void TestAddition()
            {
                var op = new Operation();
                var result = operation.addition(1, 3);
                const int expected = 4;
                Check.That(result).Equals(expected);
            }
        }
    }
}
