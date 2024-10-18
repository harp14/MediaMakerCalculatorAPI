using MediaMaker_Calculator_API.Services;

namespace MediaMakerCalculatorAPI.UnitTests
{
    [TestClass]
    public class CalculatorServiceTests
    {
        [TestMethod]
        public void Add_ValidInputs_ReturnsCorrectResult()
        {
            // Arrange
            var calculatorService = new CalculatorService();
            double firstNumber = 10;
            double secondNumber = 5;

            // Act
            double result = calculatorService.Add(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void Subtract_ValidInputs_ReturnsCorrectResult()
        {
            // Arrange
            var calculatorService = new CalculatorService();
            double firstNumber = 10;
            double secondNumber = 5;

            // Act
            double result = calculatorService.Subtract(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Multiply_ValidInputs_ReturnsCorrectResult()
        {
            // Arrange
            var calculatorService = new CalculatorService();
            double firstNumber = 10;
            double secondNumber = 5;

            // Act
            double result = calculatorService.Multiply(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(50, result);
        }

        [TestMethod]
        public void Divide_ValidInputs_ReturnsCorrectResult()
        {
            // Arrange
            var calculatorService = new CalculatorService();
            double firstNumber = 10;
            double secondNumber = 5;

            // Act
            double result = calculatorService.Divide(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Divide_SecondNumberIsZero_ThrowsDivideByZeroException()
        {
            // Arrange
            var sut = new CalculatorService();
            double firstNumber = 10;
            double secondNumber = 0;

            // Act & Assert
            Assert.ThrowsException<DivideByZeroException>(() => sut.Divide(firstNumber, secondNumber));
        }
    }
}