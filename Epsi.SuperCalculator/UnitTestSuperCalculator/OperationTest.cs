using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestSuperCalculator
{
    [TestClass]
    public class OperationTest
    {
        /// <summary>
        /// Vérifie que l'on renvoie 4 quand le nombre1 vaut 1 et nombre2 vaut 3
        /// </summary>
        [TestMethod]
        public void TestAddition()
        {
            var op = new Operation();
            var result = operation.addition(1, 3);
            const int expected = 4;
            Check.That(result).Equals(expected);
        }
    }
}
