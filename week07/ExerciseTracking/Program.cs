using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Exercise Tracking Program!\n");

        DateTime date = DateTime.Now;
        string formattedDate = date.ToString("dd MMM yyyy", CultureInfo.InvariantCulture);

        RunningActivity running1 = new RunningActivity(formattedDate, 30, 5.0);
        RunningActivity running2 = new RunningActivity(formattedDate, 25, 6.0);

        CyclingActivity cycling1 = new CyclingActivity(formattedDate, 45, 20.0);
        CyclingActivity cycling2 = new CyclingActivity(formattedDate, 60, 25.0);

        SwimmingActivity swimming1 = new SwimmingActivity(formattedDate, 40, 30);
        SwimmingActivity swimming2 = new SwimmingActivity(formattedDate, 50, 40);

        List<Activity> activities = new List<Activity>
        {
            running1,
            running2,
            cycling1,
            cycling2,
            swimming1,
            swimming2
        };

        Console.WriteLine("Activities Summary:");
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

    }
}