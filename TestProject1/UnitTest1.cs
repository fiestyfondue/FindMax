using ConsoleApp2;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        MaxNumber max = new MaxNumber();
        [SetUp]
        public void Setup()
        {
            //Integers on which the operation is to be done
            int firstValue = 10;
            int secondValue = 20;
            int thirdValue = 30;
            int expected = 30;

            //Act
            int result = max.MaxIntegerNumber(firstValue, secondValue, thirdValue);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test1()
        {
            //Arrange
            int firstValue = -9;
            int secondValue = 0;
            int thirdValue = -2;
            int expected = 0;

            //Act
            int result = max.MaxIntegerNumber(firstValue, secondValue, thirdValue);

            //Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void When_Given_FirstNumberMax_ReturnsSameNumber()
        {
            //Arrange
            int firstValue = 1;
            int secondValue = 0;
            int thirdValue = -1;
            int expected = 1;

            //Act
            int result = max.MaxIntegerNumber(firstValue, secondValue, thirdValue);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}