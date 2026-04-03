using System;
using System.Collections.Generic;
using System.Threading;

namespace MindfulnessProgram
{
    class ListingActivity : Activity
    {
        private List<string> _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt peace this month?",
            "Who are some of your personal heroes?"
        };

        public ListingActivity() : base("Listing Activity",
            "This activity will help you list positive aspects of your life.")
        {
        }

        public void Run()
        {
            StartActivity();

            Random rand = new Random();
            string prompt = _prompts[rand.Next(_prompts.Count)];
            Console.WriteLine($"\nPrompt: {prompt}");
            Console.WriteLine("Start listing items! Press Enter after each item.");

            List<string> items = new List<string>();
            DateTime endTime = DateTime.Now.AddSeconds(_duration);
            while (DateTime.Now < endTime)
            {
                if (Console.KeyAvailable)
                {
                    string input = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(input))
                        items.Add(input);
                }
            }

            Console.WriteLine($"\nYou listed {items.Count} items!");
            EndActivity();
        }
    }
}