using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Simple Menu");
        Console.WriteLine("1. Greet");
        Console.WriteLine("2. Show Date");
        Console.WriteLine("3. Show Time");
        Console.WriteLine("4. Add Numbers");
        Console.WriteLine("5. Exit");
        Console.Write("Select an option (1-5): ");
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                Console.WriteLine("Hello! Have a Nice day.");
                break;
            case "2":
                Console.WriteLine($"Todays Date: {DateTime.Now:dd-MM-yyyy}");
                break;
            case "3":
                Console.WriteLine($"Current Time: {DateTime.Now:hh:mm tt}");
                break;
            case "4":
                Console.WriteLine("Enter first number:");
                int a = Convert.ToInt32(Console.ReadLine()!);
                Console.WriteLine("Enter second number:");
                int b = Convert.ToInt32(Console.ReadLine()!);
                Console.WriteLine($"Sum={a + b}");
                break;
            case "5":
                Console.WriteLine("GoodBye!");
                break;
            defult:
                Console.WriteLine("Invalid option. Please select a number between 1 and 5.");
                break;
        }

        }

    }