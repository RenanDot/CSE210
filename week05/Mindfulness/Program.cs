using System;

class Program
{
    static void Main(string[] args)
    {
        int regulator = 0;
        
        int countBreathing = 0;
        int countListing = 0;   
        int countReflecting = 0;

        do
        {
            Console.Clear();

            Console.WriteLine("Welcome to the Mindfulness Program!\n");

            Console.WriteLine("Please select an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Quit\n");

            Console.Write("Enter the number of your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    countBreathing++;
                    break;
                case "2":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    countListing++;
                    break;
                case "3":
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Run();
                    countReflecting++;
                    break;

                case "4":
                    Console.Clear();
                    Console.WriteLine("You have completed the following activities:\n");
                    Console.WriteLine($"> Breathing Activity: {countBreathing} time(s)"); 
                    Console.WriteLine($"> Listing Activity: {countListing} time(s)");
                    Console.WriteLine($"> Reflecting Activity: {countReflecting} time(s)");
                    Console.WriteLine("\nThank you for using the Mindfulness Program. Goodbye!");
                    regulator = 1;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } while (regulator == 0);
    }
}