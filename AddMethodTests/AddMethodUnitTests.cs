using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestPracticeProblems;

namespace AddMethodTests
{
    [TestClass]
    public class AddMethodUnitTests
    {
        [TestMethod]
        public void AddMethod_AddTwoPositiveInts_ResultEqualsCorrectSum()
        {

            //Arrange
            AddMethod add = new AddMethod();
            int num1 = 1;
            int num2 = 1;
            int expected = 2;
            int actual = num1 + num2;

            //Act
            add.Add(num1, num2);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void AddMethod_AddOnePositveIntToOneNegativeInt_ResultEqualsCorrectSum()
        {
            //Arrange
            AddMethod add = new AddMethod();
            int posInt = 2;
            int negInt = -1;
            int expected = 1;
            int actual = posInt + negInt;

            //Act
            add.Add(posInt, negInt);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
