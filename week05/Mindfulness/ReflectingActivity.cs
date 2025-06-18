using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you felt proud of yourself.",
        "Reflect on a challenge you overcame.",
        "Think of a time when you helped someone in need.",
        "Think about a moment when you felt truly happy.",
        "Reflect on a lesson you've learned recently."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private List<string> _usedQuestions = new List<string>();

    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.Clear();
        Console.WriteLine("Get ready to reflect...");
        ShowSpinner(2);

        DisplayPrompt();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        Console.Clear();

        while (DateTime.Now < endTime)
        {
            DisplayQuestion();
        }

        Console.WriteLine();

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"\n--- {prompt} ---\n");
        Console.WriteLine("Take a moment to reflect on this prompt...");
        Console.WriteLine("Press Enter when you are ready to continue.");
        Console.ReadKey(true);
    }

    public void DisplayQuestion()
    {
        string question = GetRandomQuestion();
        Console.Write($"> {question} ");
        ShowSpinerVariation(13);
        _usedQuestions.Add(question); 
        _questions.Remove(question); 

        if (_questions.Count == 0)
        {   
            _questions = new List<string>(_usedQuestions); 
            _usedQuestions.Clear(); 
        }
    }
}