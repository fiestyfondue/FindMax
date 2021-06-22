using ConsoleApp2;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {

        [Test]
        public void When_Given_FirstNumberMax_ReturnsSameNumber()
        {
            //Arrange
            float firstNumber = 1;
            float secondNumber = 0;
            float thirdNumber = -1;
            float expected = 1;

            //Act
            float result = FindMaxNumber.FindMax(firstNumber, secondNumber, thirdNumber);

            //Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void When_Given_SecondNumberMax_ReturnsSameNumber()
        {
            //Arrange
            float firstNumber = 22.3f;
            float secondNumber = 33.3f;
            float thirdNumber = 0.001f;
            float expected = 33.3f;

            //Act
            float result = FindMaxNumber.FindMax(firstNumber, secondNumber, thirdNumber);

            //Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void When_Given_ThirdNumberMax_ReturnsSameNumber()
        {
            //Arrange
            float firstNumber = 0.001f;
            float secondNumber = -0.32f;
            float thirdNumber = 0.1f;
            float expected = 0.1f;

            //Act
            float result = FindMaxNumber.FindMax(firstNumber, secondNumber, thirdNumber);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}