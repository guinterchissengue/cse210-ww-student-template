using System;
using System.Collections.Generic;
using System.Threading;

namespace MindfulnessProgram
{
    class ReflectionActivity : Activity
    {
        private List<string> _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something selfless."
        };

        private List<string> _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What could you learn from this experience?",
            "What did you learn about yourself through this experience?"
        };

        public ReflectionActivity() : base("Reflection Activity",
            "This activity will help you reflect on your strengths and experiences.")
        {
        }

        public void Run()
        {
            StartActivity();

            Random rand = new Random();
            string prompt = _prompts[rand.Next(_prompts.Count)];
            Console.WriteLine($"\nPrompt: {prompt}");
            Thread.Sleep(2000);

            int elapsed = 0;
            while (elapsed < _duration)
            {
                string question = _questions[rand.Next(_questions.Count)];
                Console.WriteLine(question);
                ShowSpinner(3);
                elapsed += 3;
            }

            EndActivity();
        }
    }
}