using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Entry entry = new Entry();

        Console.WriteLine("Welcome to your journal!\n");

        int i = 0;

        Console.WriteLine("Please select your mood today:");
        Console.WriteLine("1. Happy / Content");
        Console.WriteLine("2. Sad / Down");   
        Console.WriteLine("3. Angry / Frustrated");
        Console.WriteLine("4. Anxious / Stressed");
        Console.WriteLine("5. Hopeful / Motivated");
        Console.Write("\nEnter your choice (1-5): ");

        string moodChoice = Console.ReadLine();
        Console.WriteLine();

        do
        {
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Write in the journal");
            Console.WriteLine("2. Display journal entries");
            Console.WriteLine("3. Load your journal");
            Console.WriteLine("4. Save your journal");
            Console.WriteLine("5. Change mood and continue");
            Console.WriteLine("6. Quit");
            Console.Write("\nEnter your choice (1-5): ");

            string choice = Console.ReadLine();

            Console.WriteLine();

            PromptGenerator newPrompt = new PromptGenerator();

            string prompt = newPrompt.GetRandomPrompt(moodChoice);

            string entryText = "";

            switch (choice)
            {
                case "1":
                    Console.WriteLine(prompt);
                    entryText = Console.ReadLine();

                    DateTime theCurrentTime = DateTime.Now;
                    string dateText = theCurrentTime.ToShortDateString();

                    entry = new Entry(dateText, prompt, entryText);

                    journal.AddEntry(entry);

                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    Console.WriteLine("What is the filename?");
                    string filename = Console.ReadLine();
                    journal.LoadFromFile(filename);
                    break;
                case "4":
                    Console.WriteLine("What is the filename?");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    break;
                case "5":
                    Console.WriteLine("Please reselect your mood today:");
                    Console.WriteLine("1. Happy / Content");
                    Console.WriteLine("2. Sad / Down");   
                    Console.WriteLine("3. Angry / Frustrated");
                    Console.WriteLine("4. Anxious / Stressed");
                    Console.WriteLine("5. Hopeful / Motivated");
                    Console.Write("\nEnter your choice (1-5): ");

                    moodChoice = Console.ReadLine();
                    break;
                case "6":
                    Console.WriteLine("Closing the journal. Goodbye!");
                    i = 1;
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();

        } while (i == 0);
    }
}