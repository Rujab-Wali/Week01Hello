using System;

class AgeDiscount
{
    static void Main()
    {
        Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine()!);

        Console.Write("Are you a student? (Y/N): ");
        string student = Console.ReadLine()!.Trim().ToUpper();

        double price = 100;
        double discount = 0;

        if (age < 12)
            discount = 0.5;
        else if (student == "Y")
            discount = 0.25;
        else if (age >= 60)
            discount = 0.3;
        else
            discount = 0;

        double final = price - (price * discount);

        Console.WriteLine($"Base price : {price}");
        Console.WriteLine($"Discount   : {discount * 100}%");
        Console.WriteLine($"Final price: {final}");
    }
}