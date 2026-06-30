Console.WriteLine("=== Statistics App ===");

int[] numbers = { 4, 8, 15, 16, 23, 42 };

if (numbers.Length == 0)
{
    Console.WriteLine("Error: no input data provided.");
    return;
}

Console.WriteLine("Sum: " + StatisticsHelper.Sum(numbers));