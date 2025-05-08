namespace FundamentalsChallenge

{
  public class Program
  {
    static void Main()
    {
      while (true)
      {
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1 - Welcome message");
        Console.WriteLine("2 - Full name message");
        Console.WriteLine("3 - Arithmetic operations");
        Console.WriteLine("4 - Word and character counter");
        Console.WriteLine("5 - Vehicle license plate");
        Console.WriteLine("6 - Date printer");
        Console.WriteLine("7 - Exit");
        Console.Write("Enter your choice: ");

        var input = Console.ReadLine();

        switch (input)
        {
          case "1":
            var welcomeMessage = new WelcomeMessage();
            welcomeMessage.PrintWelcomeMessage();
            break;

          case "2":
            var welcome = new WelcomeMessage();
            welcome.PrintFullName();
            break;

          case "3":
            Console.WriteLine("Please enter the first number: ");
            var firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the second number: ");
            var secondNumber = Convert.ToDouble(Console.ReadLine());
            var arithmeticOperations = new ArithmeticOperations(firstNumber, secondNumber);
            arithmeticOperations.PrintSum();
            arithmeticOperations.PrintSubtraction();
            arithmeticOperations.PrintMultiplication();
            arithmeticOperations.PrintDivision();
            arithmeticOperations.PrintMean();
            break;

          case "4":
            WordCharacterCounter.WordCharacterCounterPrint();
            break;

          case "5":
            VehicleLicensePlate.ValidatePlate();
            break;

          case "6":
            DatePrintter.PrintDateManyFormats();
            break;

          case "7":
            Console.WriteLine("Exiting the program...");
            return;

          default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
        }

        Console.WriteLine();
      }
    }
  }
}
