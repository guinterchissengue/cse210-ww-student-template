using System;
using System.Threading;

namespace MindfulnessProgram
{
    // Base class for all activities
    class Activity
    {
        protected string _activityName;
        protected string _description;
        protected int _duration; 

        public Activity(string name, string description)
        {
            _activityName = name;
            _description = description;
        }

        // Method to start activity
        public void StartActivity()
        {
            Console.Clear();
            Console.WriteLine($"--- {_activityName} ---");
            Console.WriteLine(_description);
            Console.Write("Enter duration in seconds: ");
            while (!int.TryParse(Console.ReadLine(), out _duration) || _duration <= 0)
            {
                Console.Write("Please enter a valid positive number: ");
            }

            Console.WriteLine("Get ready...");
            ShowSpinner(3);
        }

        // Method to end activity
        public void EndActivity()
        {
            Console.WriteLine("\nGood job!");
            Console.WriteLine($"You completed {_activityName} for {_duration} seconds.");
            ShowSpinner(3);
        }

        // Simple spinner animation
        protected void ShowSpinner(int seconds)
        {
            string[] spinner = { "/", "-", "\\", "|" };
            for (int i = 0; i < seconds * 4; i++)
            {
                Console.Write(spinner[i % spinner.Length]);
                Thread.Sleep(250);
                Console.Write("\b");
            }
            Console.WriteLine();
        }
    }
}