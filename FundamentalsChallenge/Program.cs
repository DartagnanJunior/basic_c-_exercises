namespace FundamentalsChallenge

{
  public class Program
  {
    static void Main()
    {
      var WelcomeMessage = new WelcomeMessage();
      WelcomeMessage.PrintWelcomeMessage();
      WelcomeMessage.PrintFullName();

      var arithmeticOperations = new ArithmeticOperations(10, 5);
      arithmeticOperations.PrintSum();
      arithmeticOperations.PrintSubtraction();
      arithmeticOperations.PrintMultiplication();
      arithmeticOperations.PrintDivision();
      arithmeticOperations.PrintMean();

      WordCharacterCounter.WordCharacterCounterPrint();
    }
  }
}
