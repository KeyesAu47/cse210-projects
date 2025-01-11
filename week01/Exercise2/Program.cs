using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

                // Prompt the user for their grade percentage
        Console.Write("Enter your grade percentage: ");
        string input = Console.ReadLine();
        int percentage;

        // Validate user input to ensure it's an integer
        if (!int.TryParse(input, out percentage) || percentage < 0 || percentage > 100)
        {
            Console.WriteLine("Invalid input. Please enter a percentage between 0 and 100.");
            return;
        }

        // Determine the letter grade
        string letter = "";
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine "+" or "-" for the letter grade
        string sign = "";
        int lastDigit = percentage % 10;

        if (letter != "F") // "F" grades don't have a "+" or "-"
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }

            // Handle "A+" case
            if (letter == "A" && sign == "+")
            {
                sign = ""; // There is no "A+"
            }
        }

        // Combine letter and sign
        string fullGrade = letter + sign;

        // Display the letter grade
        Console.WriteLine($"Your grade is: {fullGrade}");

        // Determine if the user passed the course
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Don't give up! Better luck next time.");
        }
    }

    
}