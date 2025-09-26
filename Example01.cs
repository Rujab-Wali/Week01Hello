using System;

class Program
{
    static void Main()
    {
        Console.Write("First name: ");
        string first = Console.ReadLine().Trim();

        Console.Write("Last name: ");
        string last = Console.ReadLine().Trim();

        char f = char.ToUpper(first[0]);
        char l = char.ToUpper(last[0]);

        Console.WriteLine($"Hello, {first} {last} ({f}.{l}.)");
    }
}