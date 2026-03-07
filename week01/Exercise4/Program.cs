using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Numbers List
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Variable 
        int number;

        // Loop 
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number); 
            }
        } while (number != 0);

        // Sum of the numbers
        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }

        double average = 0;
        if (numbers.Count > 0)
        {
            average = (double)sum / numbers.Count;
        }

        // Find the largest number
        int max = int.MinValue;
        foreach (int n in numbers)
        {
            if (n > max)
            {
                max = n;
            }
        }

        // Results
        Console.WriteLine("The sum is: " + sum);
        Console.WriteLine("The average is: " + average);
        Console.WriteLine("The largest number is: " + max);
    }
}