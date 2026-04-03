using System;
using System.Threading;

namespace MindfulnessProgram
{
    class BreathingActivity : Activity
    {
        public BreathingActivity() : base("Breathing Activity",
            "This activity will help you relax by guiding your breathing.")
        {
        }

        public void Run()
        {
            StartActivity();

            int elapsed = 0;
            while (elapsed < _duration)
            {
                Console.WriteLine("Breathe in...");
                Thread.Sleep(4000);
                elapsed += 4;

                Console.WriteLine("Breathe out...");
                Thread.Sleep(4000);
                elapsed += 4;
            }

            EndActivity();
        }
    }
}