using System;

public class Class1
{
    static void Main() {
        Console.WriteLine("Please inform your first name.");
        var firstName = Console.ReadLine();
        Console.WriteLine($"Welcome to our Program {firstName}");
        Console.WriteLine("Please inform your last name.");
        var lastName = Console.ReadLine();
        Console.WriteLine($"Thats your full name: {firstName} {lastName}");
        Console.WriteLine("Press any key to exit…");
        Console.ReadKey();
    }

}
