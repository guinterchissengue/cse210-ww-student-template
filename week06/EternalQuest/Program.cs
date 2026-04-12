using System;

/*
EXCEEDING REQUIREMENTS:
I added:

- A level system that increases as you gain points
- Titles that change depending on your level
- Fun feedback messages
- A bit of personality

The goal was to make it more motivating and enjoyable to use, not just functional.
*/

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        while (true)
        {
            Console.WriteLine("\n--- Eternal Quest ---");

            manager.DisplayScore();

            Console.WriteLine("\n1. Create Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. List Goals");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Load");
            Console.WriteLine("6. Exit");

            Console.Write("\nChoose: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1) manager.CreateGoal();
            else if (choice == 2) manager.RecordEvent();
            else if (choice == 3) manager.ListGoals();
            else if (choice == 4) manager.Save("goals.txt");
            else if (choice == 5) manager.Load("goals.txt");
            else if (choice == 6) break;
        }
    }
}