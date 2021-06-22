using ConsoleApp2;
using NUnit.Framework;

namespace StringTest
{
    public class Tests
    {
        [Test]
        public void When_Given_ThirdNumberMax_ReturnsSameNumber()
        {
            //Arrange
            int firstNumber = 10;
            int secondNumber = 20;
            int thirdNumber = 30;
            int expected = 30;

            //Act
            int result = FindMaxNumber.FindMax(firstNumber, secondNumber, thirdNumber);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void When_Given_SecondNumberMax_ReturnsSameNumber()
        {
            //Arrange
            int firstNumber = -9;
            int secondNumber = 0;
            int thirdNumber = -2;
            int expected = 0;

            //Act
            int result = FindMaxNumber.FindMax(firstNumber, secondNumber, thirdNumber);

            //Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void When_Given_FirstNumberMax_ReturnsSameNumber()
        {
            //Arrange
            int firstNumber = 1;
            int secondNumber = 0;
            int thirdNumber = -1;
            int expected = 1;

            //Act
            int result = FindMaxNumber.FindMax(firstNumber, secondNumber, thirdNumber);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}