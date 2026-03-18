using System;

class Program
{
    static void Main(string[] args)
    {
        // main objects
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int option = 0;
        int entryCount = 0;

        while (option != 5)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");

            option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                // get a random question
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);

                Console.Write("> ");
                string response = Console.ReadLine();

                // create a new entry
                Entry entry = new Entry();
                entry._date = DateTime.Now.ToShortDateString();
                entry._prompt = prompt;
                entry._response = response;

                // add to journal
                journal.AddEntry(entry);

                entryCount++;
                Console.WriteLine($"Entries written: {entryCount}");
            }
            else if (option == 2)
            {
                // show all entries
                journal.DisplayAll();
            }
            else if (option == 3)
            {
                Console.Write("Enter filename: ");
                string fileName = Console.ReadLine();

                // save 
                journal.SaveToFile(fileName);
            }
            else if (option == 4)
            {
                Console.Write("Enter filename: ");
                string fileName = Console.ReadLine();

                // load 
                journal.LoadFromFile(fileName);
            }
        }
    }
}