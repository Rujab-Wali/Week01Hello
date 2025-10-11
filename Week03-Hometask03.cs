using System;

class StringLengthChecker
{
    static void Main()

    {
        Console.WriteLine("Enter any text:");
        string input = Console.ReadLine();
        if (string.IsNullOrEmpty(input))
            Console.WriteLine("Empty String");
        else if (string.IsNullOrWhiteSpace(input))
            Console.WriteLine("WhiteSpace String");
        else if (input.Length < 5)
            Console.WriteLine("Short String");
        else if (input.Length > 20)
            Console.WriteLine("Long String");
        else
            Console.WriteLine("Normal Length string");
    }
}

