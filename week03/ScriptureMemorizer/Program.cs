using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // List of scriptures + extra creativity 
        List<Scripture> scriptures = new List<Scripture>();

        scriptures.Add(new Scripture(
            new Reference("John", 3, 16),
            "For God so loved the world that he gave his only begotten Son"
        ));

        scriptures.Add(new Scripture(
            new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all thine heart and lean not unto thine own understanding"
        ));

        scriptures.Add(new Scripture(
            new Reference("Psalm", 23, 1),
            "The Lord is my shepherd; I shall not want"
        ));

        // Select a random scripture
        Random rand = new Random();
        Scripture selected = scriptures[rand.Next(scriptures.Count)];

        // Loop  all words or 'quit'
        while (true)
        {
            Console.Clear();
            Console.WriteLine(selected.GetDisplayText());

            // Check hidden words
            if (selected.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll words are hidden! End of the program.");
                break;
            }

            Console.WriteLine("\nPress ENTER to continue or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            // Hide 3 random words
            selected.HideRandomWords(3);
        }
    }
}