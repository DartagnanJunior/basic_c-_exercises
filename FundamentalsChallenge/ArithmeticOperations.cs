namespace FundamentalsChallenge
{
  public class ArithmeticOperations
  {
    private readonly double firstNumber;
    private readonly double secondNumber;

    public ArithmeticOperations(double firstNumber, double secondNumber)
    {
      this.firstNumber = firstNumber;
      this.secondNumber = secondNumber;
    }

    public void PrintSum()
    {
      Console.WriteLine($"Sum: {firstNumber + secondNumber}");
    }

    public void PrintSubtraction()
    {
      Console.WriteLine($"Subtraction: {firstNumber - secondNumber}");
    }

    public void PrintMultiplication()
    {
      Console.WriteLine($"Multiplication: {firstNumber * secondNumber}");
    }

    public void PrintDivision()
    {
      if (secondNumber != 0)
      {
        Console.WriteLine($"Division: {firstNumber / secondNumber}");
      }
      else
      {
        Console.WriteLine("Division by zero is not allowed.");
      }
    }

    public void PrintMean()
    {
      Console.WriteLine($"Mean: {(firstNumber + secondNumber) / 2}");
    }
  }
}
