namespace FundamentalsChallenge
{
  public class WelcomeMessage
  {
    string? firstName;

    public void PrintWelcomeMessage()
    {
      Console.WriteLine("Please inform your first name.");
      firstName = Console.ReadLine();
      Console.WriteLine($"Welcome to our Program {firstName}");
    }

    public void PrintFullName()
    {
      Console.WriteLine("Please inform your first name.");
      firstName = Console.ReadLine();
      Console.WriteLine("Please inform your last name.");
      var lastName = Console.ReadLine();
      Console.WriteLine($"Thats your full name: {firstName} {lastName}");
    }
  }
}
