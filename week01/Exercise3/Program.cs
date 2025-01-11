using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        
                do
        {
            // Generate a random magic number between 1 and 100
            Random random = new Random();
            int magicNumber = random.Next(1, 101);

            Console.WriteLine("Guess My Number Game!");
            Console.WriteLine("I have selected a magic number between 1 and 100. Try to guess it!");

            int guess = 0;
            int guessCount = 0;

            // Loop until the user guesses the correct number
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it! The magic number was {magicNumber}. It took you {guessCount} guesses.");
                }
            }

            // Ask if the user wants to play again
            Console.Write("Do you want to play again? (yes/no): ");
        } while (Console.ReadLine()?.ToLower() == "yes");

        Console.WriteLine("Thanks for playing! Goodbye.");
    }
}