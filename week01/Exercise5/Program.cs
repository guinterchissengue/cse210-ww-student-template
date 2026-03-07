using System;

class Program
{
    static void Main(string[] args)
    {
        //  Display the welcome message
        DisplayWelcome();

        // Call the function 
        string userName = PromptUserName();

        // Call the function 
        int favoriteNumber = PromptUserNumber();

        // Call the function 
        int squaredNumber = SquareNumber(favoriteNumber);

        // Call the function 
        DisplayResult(userName, squaredNumber);
    }

    // Function to display welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Function to ask for the user and return it
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    
    // Function to ask for the user favorite number and return it
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        return number;
    }

    // Function to square a number and return the result
    static int SquareNumber(int num)
    {
        return num * num;
    }

    // Function to display the final result
    static void DisplayResult(string name, int squared)
    {
        Console.WriteLine($"{name}, the square of your number is {squared}");
    }
}