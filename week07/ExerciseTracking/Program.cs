using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("06 Jun 2025", 30, 5));
        activities.Add(new Cycling("07 Jun 2025", 45, 40));
        activities.Add(new Swimming("08 Jun 2025", 20, 7));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}