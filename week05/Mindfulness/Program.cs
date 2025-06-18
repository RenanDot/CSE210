using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!\n");

        Console.WriteLine("Please select an activity:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Listing Activity");
        Console.WriteLine("3. Reflecting Activity");
        Console.WriteLine("4. Quit\n");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
                break;
            // case "2":
            //     ListingActivity listingActivity = new ListingActivity();
            //     listingActivity.Run();
            //     break;
            // case "3":
            //     ReflectingActivity reflectingActivity = new ReflectingActivity();
            //     reflectingActivity.Run();
                //break;
            case "4":
                Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }
}