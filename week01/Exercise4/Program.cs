using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

         // Create a list to store user-entered numbers
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Input loop
        while (true)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            // Stop when the user enters 0
            if (number == 0)
                break;

            // Add the number to the list
            numbers.Add(number);
        }

        // Ensure the list has at least one number
        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers were entered.");
            return;
        }

        // Core Requirements
        int sum = numbers.Sum();
        double average = numbers.Average();
        int max = numbers.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

        // Stretch Challenges
        // Find the smallest positive number
        int smallestPositive = numbers.Where(n => n > 0).DefaultIfEmpty(int.MaxValue).Min();

        // Sort the list
        numbers.Sort();

        Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}