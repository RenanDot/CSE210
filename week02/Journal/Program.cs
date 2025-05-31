using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your journal!");

        int i = 0;
        do
        {
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Write in the journal");
            Console.WriteLine("2. Display journal entries");
            Console.WriteLine("3. Load your journal");
            Console.WriteLine("4. Save your journal");
            Console.WriteLine("5. Quit");
            Console.Write("Enter your choice (1-5): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("You chose to write in the journal.");
                    // Add code to write in the journal
                    break;
                case "2":
                    Console.WriteLine("You chose to display journal entries.");
                    // Add code to display journal entries
                    break;
                case "3":
                    Console.WriteLine("You chose to load your journal.");
                    // Add code to load the journal
                    break;
                case "4":
                    Console.WriteLine("You chose to save your journal.");
                    // Add code to save the journal
                    break;
                case "5":
                    Console.WriteLine("Closing the journal. Goodbye!");
                    i = 1; // Set i to 1 to exit the loop
                    return; // Exit the program
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

        } while (i == 0);
    }
}