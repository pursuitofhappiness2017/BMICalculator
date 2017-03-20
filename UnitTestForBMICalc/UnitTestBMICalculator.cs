using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Person;

namespace UnitTestForBMICalc
{
    [TestClass]
    public class UnitTestBMICalculator
    {
        [TestMethod]
        public void Input_Person_Height_170CM_Weight_55KG_Output_太瘦()
        {
            //Arrange
            var expect = "太瘦";

            var person = new Person.Person(170, 55);

            //Act
            var actual = person.CalculateBMI();

            //Assert
            Assert.AreEqual(expect, actual);
        }
    }
}
