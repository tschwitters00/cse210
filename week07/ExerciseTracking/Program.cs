using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = 
        [
            new RunningActivity("03 Nov 2022", 30, 3.0),
            new CyclingActivity("05 Dec 2023", 60, 11),
            new SwimmingActivity("25 Feb 2025", 20, 55)
        ];

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}