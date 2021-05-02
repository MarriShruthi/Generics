using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MSTestGenerics
{
    [TestClass]
    public class Test
    {
        /// <summary>
        /// Check Maximum String and Return Peach
        /// </summary>
        [TestMethod]
        public void CheckFirstStringWhenGreaterReturnPeach()
        {
            string max = "Peach";
            string Result = MaximumNumber.StringMaximumNumber("Peach", "Apple", "Banana");
            Assert.AreEqual(max, Result);
        }

        /// <summary>
        /// Check MAximum String and Return Strawberry
        /// </summary>
        [TestMethod]
        public void CheckSecondStringWhenGreaterRetrunStrawberry()
        {
            string max = "Strawberry";
            string Result = MaximumNumber.StringMaximumNumber("Apple", "Strawberry", "Peach");
            Assert.AreEqual(max, Result);
        }

        /// <summary>
        /// Check Maximum Sting And Return Peach
        /// </summary>
        [TestMethod]
        public void CheckThirdStringWhenGreaterRetrunPeach()
        {
            string max = "Peach";
            string Result = MaximumNumber.StringMaximumNumber("Apple", "Banana", "Peach");
            Assert.AreEqual(max, Result);
        }
    }
}