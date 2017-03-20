using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BMICalculator;

namespace UnitTestForBMICalc
{
    [TestClass]
    public class UnitTestBMICalculator
    {
        [TestMethod]
        public void Input_BMI_19_Output_太瘦()
        {
            //Arrange
            var expect = "太瘦";

            //Act
            var actual = new Person().CalculateBMI();

            //Assert
            Assert.AreEqual(expect, actual);
        }
    }
}
