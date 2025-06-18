using System;
using System.Collections.Generic;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}!\n");
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.WriteLine("How long, in seconds, would you like to do this activity? (Enter a number)");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done!");
        ShowSpinner(2);
        Console.WriteLine($"You have completed the {_name} for {_duration} seconds.");
        ShowSpinner(4);
        Console.Clear();
    }

    public void ShowSpinner(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        List<string> spinnerFrames = new List<string> { "|", "/", "-", "\\", "|", "/", "-", "\\" };

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = spinnerFrames[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= spinnerFrames.Count)
            {
                i = 0;
            }

        }

        Console.WriteLine();
    }

    public void ShowSpinerVariation(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        List<string> spinnerFrames = new List<string> { "[    ]", "[=   ]", "[==  ]", "[=== ]", "[ ===]", "[  ==]", "[   =]" };

        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write($"{spinnerFrames[i % spinnerFrames.Count]}");
            Thread.Sleep(500);
            Console.Write("\b\b\b\b\b\b");
            i++;

        }

        Console.Write("         \n");
    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            System.Threading.Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void ProgressBar(int total, int delay)
    {
        total--;

        for (int i = 0; i <= total; i++)
        {
            Console.Write("\r[");
            Console.Write(new string('#', i));
            Console.Write(new string(' ', total - i));
            Console.Write($"] {total-i} seconds");
            Thread.Sleep(delay);
        }

        Console.SetCursorPosition(0, Console.CursorTop);
        Console.WriteLine("Completed!                                 ");
    }
    
    public void InverseProgressBar(int total, int delay)
    {
        total--; 

        for (int i = 0; i <= total; i++)
        {
            Console.Write("\r[");
            Console.Write(new string('#', total - i));
            Console.Write(new string(' ', i));
            Console.Write($"] {total-i} seconds");
            Thread.Sleep(delay);
        }

        Console.SetCursorPosition(0, Console.CursorTop);
        Console.WriteLine("Completed!                                 ");
    }
}