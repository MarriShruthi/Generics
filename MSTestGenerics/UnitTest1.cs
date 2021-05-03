using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MSTestGenerics
{
    [TestClass]
    public class Test
    {
        private object genericint;

        [TestMethod]
        public void MaximumNumberGenericInteger_PassThreeNumbers_ReturnMaximumNumber()
        {
            int[] intArray = { 111, 333, 444, 555, 666 };
            Generic<int> generic = new Generic<int>(intArray); //crating object with int data type
            int result = generic.MaxMethod();
            int max = 666;
            Assert.AreEqual(result, max);
        }


        [TestMethod]
        public void MaximumNumberGenericFloat_PassThreeNumbers_ReturnMaximumNumber()
        {
            double[] doubleArray = { 11.1, 44.4, 3.33, 55.5, 8.88 };
            Generic<double> genericDouble = new Generic<double>(doubleArray);
            double result = genericDouble.MaxMethod();
            double max = 55.5;
            Assert.AreEqual(result, max);
        }

        [TestMethod]
        public void MaximumNumberGenericString_PassThreeNumbers_ReturnMaximumNumber()
        {
            string[] stringArray = { "11", "22", "33", "55", "99" };
            Generic<string> genericString = new Generic<string>(stringArray);
            string result = genericString.MaxMethod();
            string max = "99";
            Assert.AreEqual(result, max);
        }
    }
}

