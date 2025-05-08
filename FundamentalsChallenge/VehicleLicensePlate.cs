using System.Text.RegularExpressions;

namespace FundamentalsChallenge
{
  public class VehicleLicensePlate
  {

    public static bool ValidatePlate()
    {
      Console.WriteLine("Please enter a vehicle license plate: ");
      var plate = Console.ReadLine();

      if (plate == null)
      {
        Console.WriteLine("Invalid plate. You did not enter a license plate.");
        return false;
      }

      if (plate.Length != 7)
      {
        Console.WriteLine("Invalid plate. The license plate must be 7 characters long.");
        return false;
      }

      var regex = new Regex(@"^[A-Za-z]{3}[0-9]{4}$");
      if (!regex.IsMatch(plate))
      {
        Console.WriteLine("Invalid plate. The license plate must have 3 letters followed by 4 numbers.");
        return false;
      }

      Console.WriteLine("Valid license plate!");
      return true;
    }
  }
}