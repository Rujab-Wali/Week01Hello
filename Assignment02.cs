using System;

class Program
{
    static void Main()
    {
        int n;
        while (true)
        {
            Console.Write("How many readings? ");
            if (int.TryParse(Console.ReadLine(), out n) && n > 0) break;
            Console.WriteLine("Enter a number > 0.");
        }

        int[] temps = new int[n];
        for (int i = 0; i < n; i++)
        {
            while (true)
            {
                Console.Write($"Temp #{i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out temps[i])) break;
                Console.WriteLine("Invalid, try again.");
            }
        }

        int min = temps[0], max = temps[0], sum = 0;
        for (int i = 0; i < n; i++)
        {
            if (temps[i] < min) min = temps[i];
            if (temps[i] > max) max = temps[i];
            sum += temps[i];
        }
        double avg = sum / (double)n;

        Console.WriteLine($"\nMin = {min}, Max = {max}, Avg = {avg:F2}");

        Console.WriteLine("\nHistogram:");
        foreach (int t in temps)
        {
            Console.Write($"{t,3}: ");
            for (int j = 0; j < Math.Abs(t); j++) Console.Write("*");
            Console.WriteLine();
        }
    }
}