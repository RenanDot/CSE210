using System;

/* 
    Program written by Renan Daniel de Campos, to exceed the requirements 
    for this assignment, I added a menu to select between a predefined scripture 
    or entering your own. When entering your own scripture, you can specify the 
    book, chapter, start verse, end verse (optional), and the text of the scripture.    
*/
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine("Please select an option:");
        Console.WriteLine("1. Use a predefined scripture");
        Console.WriteLine("2. Enter your own scripture");

        string choice = Console.ReadLine();

        Scripture scripture;

        if (choice == "2")
        {
            Console.Clear();
            Console.WriteLine("Enter the book name:");
            string book = Console.ReadLine();

            Console.WriteLine("\nEnter the chapter number:");
            int chapter = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter the start verse number:");
            int firstVerse = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter the end verse number (or press Enter for single verse):");

            string endVerseInput = Console.ReadLine();
            int endVerse = firstVerse;

            if (!string.IsNullOrEmpty(endVerseInput))
            {
                endVerse = int.Parse(endVerseInput);
            }

            Console.WriteLine("\nEnter the scripture text:");
            string text = Console.ReadLine();

            Reference reference = new Reference(book, chapter, firstVerse, endVerse);
            scripture = new Scripture(reference, text);

        }
        else
        {
            Console.WriteLine("Using a predefined scripture...");
            PresetScriptures presetScriptures = new PresetScriptures();
            scripture = presetScriptures.GetRandomScripture();
        }


        while (true)
        {
            Console.Clear();
            scripture.GetDisplayText();

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nCongratulations! You have memorized the scripture.");
                break;
            }

            Console.WriteLine("\nPress Enter to hide some words or type 'quit' to exit)");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            if (input == "")
            {
                scripture.HideRandomWords(3);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}