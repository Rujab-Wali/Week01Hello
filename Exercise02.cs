using System;
class Program
{
    static void Main()
    {
        int count = 0, sum = 0, min = 0, max = 0;
        while (true)
        {
            Console.Write("Enter number (blank to stop): ");
            string input = Console.ReadLine().Trim();
            if (input == "") break;
            if (int.TryParse(input, out int n))
            {
                if (count == 0) { min = max = n; }
                else { if (n < min) min = n; if (n > max) max = n; }
                sum += n; count++;
            }
            else Console.WriteLine("Not a valid whole number.");
        }
        if (count > 0) Console.WriteLine($"Count={count}, Min={min}, Max={max}, Avg={sum / (double)count:F2}");
        else Console.WriteLine("No numbers entered.");
    }
}
