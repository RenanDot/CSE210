using System;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "What is a recent accomplishment you are proud of?",
        "What are some recent acts of kindness you have witnessed or performed?",
        "What are things in your life that you are grateful for?",
        "What challenges have you overcome recently?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _count = 0;
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.Clear();
        Console.WriteLine("Get ready to list...");

        ShowSpinner(3);

        DisplayPrompt();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        List<string> userList = GetListFromUser(endTime);

        Console.WriteLine($"\nYou listed {userList.Count} items.\n");

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"List as many responses as you can to the following prompt:");
        Console.WriteLine($"\n--- {prompt} ---\n");
        Console.Write("You may begin in: ");
        ShowCountdown(6);
        Console.WriteLine();
    }

    private List<string> GetListFromUser(DateTime endTime)
    {
        List<string> userList = new List<string>();

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            userList.Add(response);
            _count++;
        }

        return userList;
    }
}