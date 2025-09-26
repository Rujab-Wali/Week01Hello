using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine().Trim();
        if (string.IsNullOrWhiteSpace(name)) { Console.WriteLine("Invalid name."); return; }

        Console.Write("Enter your age: ");
        string ageText = Console.ReadLine().Trim();
        if (!int.TryParse(ageText, out int age) || age <= 0 || age > 120) { Console.WriteLine("Invalid age."); return; }

        Console.Write("Enter your city: ");
        string city = Console.ReadLine().Trim();
        if (string.IsNullOrWhiteSpace(city)) { Console.WriteLine("Invalid city."); return; }

        Console.WriteLine("\n--- Profile ---");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age : {age}");
        Console.WriteLine($"City: {city}");
    }
}