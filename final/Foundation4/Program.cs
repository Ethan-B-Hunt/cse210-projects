using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running(new DateTime(2022, 11, 03), 30, 3.0));
        activities.Add(new Cycling(new DateTime(2022, 11, 03), 30, 9.6));
        activities.Add(new Swimming(new DateTime(2022, 11, 03), 30, 2));

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
