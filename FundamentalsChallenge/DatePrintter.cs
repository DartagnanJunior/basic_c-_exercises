using System.Globalization;

namespace FundamentalsChallenge
{
  public class DatePrintter
  {

    public static void PrintDateManyFormats()
    {
      var now = DateTime.Now;
      var culture = new CultureInfo("pt-BR");

      Console.WriteLine(now.ToString("dddd, dd 'de' MMMM 'de' yyyy HH:mm:ss", culture));
      Console.WriteLine(now.ToString("dd/MM/yyyy", culture));
      Console.WriteLine(now.ToString("HH:mm:ss", culture));
      Console.WriteLine(now.ToString("dd 'de' MMMM 'de' yyyy", culture));
    }
  }
}
