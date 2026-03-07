using System;

class Program
{
    static void Main(string[] args)
    {
        // Number generator
        Random randomGenerator = new Random();
       // Generator
        int magicNumber = randomGenerator.Next(1, 101); 

       // Variable
        int guess = 0; 

        Console.WriteLine("Welcome to Guess My Number!");
        Console.WriteLine("I have picked a number between 1 and 100. Can you guess it?");

        // Loop
        while (guess != magicNumber)
        {
            // Ask the user for a guess
            Console.Write("What is your guess? ");
            string input = Console.ReadLine();

            // Convertion
            guess = int.Parse(input);

            // Comparation
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
                Console.WriteLine("You guessed it!");
            }
        }
    }
}