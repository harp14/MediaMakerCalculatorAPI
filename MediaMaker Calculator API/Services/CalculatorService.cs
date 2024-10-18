namespace MediaMaker_Calculator_API.Services
{
    public class CalculatorService : ICalculatorService
    {
        public double Add(double firstNumber, double secondNumber) => firstNumber + secondNumber;
        public double Subtract(double firstNumber, double secondNumber) => firstNumber - secondNumber;
        public double Multiply(double firstNumber, double secondNumber) => firstNumber * secondNumber;
        public double Divide(double firstNumber, double secondNumber)
        {
            if (secondNumber == 0)
            {
                throw new DivideByZeroException();
            }
            return firstNumber / secondNumber;
        }
    }
}
