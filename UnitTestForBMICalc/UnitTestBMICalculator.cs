using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Person;

namespace UnitTestForBMICalc
{
    [TestClass]
    public class UnitTestBMICalculator
    {
        [TestMethod]
        public void Input_Men_Height_170CM_Weight_55KG_Output_太瘦()
        {
            //Arrange
            var expect = "太瘦";

            var person = new Men(170, 55);

            //Act
            var actual = person.CalculateBMI();

            //Assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Input_Men_Height_170CM_Weight_80KG_Output_太胖()
        {
            //Arrange
            var expect = "太胖";

            var person = new Men(170, 80);

            //Act
            var actual = person.CalculateBMI();

            //Assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Input_Men_Height_170CM_Weight_60KG_Output_適中()
        {
            //Arrange
            var expect = "適中";

            var person = new Men(170, 60);

            //Act
            var actual = person.CalculateBMI();

            //Assert
            Assert.AreEqual(expect, actual);
        }
    }
}
