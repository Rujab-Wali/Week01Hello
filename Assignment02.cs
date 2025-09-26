using System;

int N;

// Step 1: Read and validate N > 0
while (true)
{
    Console.Write("How many temperature readings (N > 0)? ");
    string input = Console.ReadLine() ?? "";

    if (int.TryParse(input, out N) && N > 0)
    {
        break;
    }
    Console.WriteLine("Invalid input. Please enter a positive integer.");
}

// Step 2: Create array
int[] temps = new int[N];

// Step 3: Read N integers into the array
for (int i = 0; i < N; i++)
{
    while (true)
    {
        Console.Write($"Enter temperature #{i + 1}: ");
        string tempInput = Console.ReadLine() ?? "";

        if (int.TryParse(tempInput, out int t))
        {
            temps[i] = t;
            break;
        }
        Console.WriteLine("Invalid input. Please enter a valid integer.");
    }
}

// Step 4: Compute min, max, sum
int min = temps[0];
int max = temps[0];
long sum = 0;

for (int i = 0; i < N; i++)
{
    int v = temps[i];
    if (v < min) min = v;
    if (v > max) max = v;
    sum += v;
}

// Step 5: Compute average
double avg = sum / (double)N;

// Step 6: Print results
Console.WriteLine("\n--- Temperature Report ---");
Console.WriteLine($"Min = {min}");
Console.WriteLine($"Max = {max}");
Console.WriteLine($"Avg = {avg:F2}");

// Step 7: Print histogram
Console.WriteLine("\nHistogram (value : stars = occurrences):");
for (int value = min; value <= max; value++)
{
    int count = 0;
    for (int i = 0; i < N; i++)
    {
        if (temps[i] == value) count++;
    }

    if (count > 0)
    {
        Console.WriteLine($"{value,4} : {new string('*', count)}");
    }
}