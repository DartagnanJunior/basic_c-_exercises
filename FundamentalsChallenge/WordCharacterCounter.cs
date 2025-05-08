namespace FundamentalsChallenge
{
  public class WordCharacterCounter
  {

    public static void WordCharacterCounterPrint()
    {
      Console.WriteLine("Please enter a word: ");
      var words = Console.ReadLine();
      var wordsClean = words?.Trim();

      if (wordsClean?.Length > 0)
      {
        Console.WriteLine($"The word '{wordsClean}' has {wordsClean.Length} characters.");
      }
      else
      {
        Console.WriteLine("You did not enter a word.");
      }

    }
  }
}
