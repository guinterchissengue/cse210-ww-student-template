using System;

class Program
{
    static void Main(string[] args)
    {
        // User first name of the
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // User last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // "Shows the name as 'last name, first name last name'."
        Console.WriteLine();
        Console.WriteLine("Your name is " + lastName + ", " + firstName + " " + lastName + ".");
    }
}