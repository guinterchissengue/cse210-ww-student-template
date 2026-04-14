using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store all activities 
        List<Activity> activities = new List<Activity>();

        // Add different types of activities
        activities.Add(new Running("03 Nov 2022", 30, 3.0));  // 3 miles
        activities.Add(new Cycling("04 Nov 2022", 45, 15.0)); // 15 mph
        activities.Add(new Swimming("05 Nov 2022", 40, 40));  // 40 laps

        // Loop through the list and print summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}