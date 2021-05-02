using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MSTestGenerics
{
    [TestClass]
    public class Test
    {
        /// <summary>
        /// TC1.1 When Three integers are given to the method and largest number among all numbers is at position 1st, this test case should pass
        /// </summary>
        /// <param name="firstValue">firstValue will be maximum of all three integer values</param>
        [TestMethod]
        [DataRow(3000, 2000, 1000)]
        public void GivenThreeIntegersWhenMaxIntegerAtPositionOneShouldReturnThatValue(int firstValue, int secondValue, int thirdValue)
        {

            int expectedResult = firstValue;
            int result = MaximumNumber.MaxIntNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// TC1.2 When Three integers are given to the method and largest number among all numbers is at position 2nd, this test case should pass
        /// </summary>
        [TestMethod]
        [DataRow(1000, 3000, 2000)]
        public void GivenThreeIntegersWhenMaxIntegerAtPositionTwoShouldReturnThatValue(int firstValue, int secondValue, int thirdValue)
        {
            int expectedResult = secondValue;
            int result = MaximumNumber.MaxIntNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// TC1.3 When Three integers are given to the method and largest number among all numbers is at position 3rd, this test case should pass
        /// </summary>
        [TestMethod]
        [DataRow(1000, 2000, 3000)]
        public void GivenThreeIntegersWhenMaxIntegerAtPositionThreeShouldReturnThatValue(int firstValue, int secondValue, int thirdValue)
        {
            int expectedResult = thirdValue;
            int result = MaximumNumber.MaxIntNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expectedResult, result);
        }
    }
}