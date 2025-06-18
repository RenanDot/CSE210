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
        string _duration = Console.ReadLine();
    }

    public void DisplayEndingMessage()
    {

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
    
    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"Starting in {i} seconds...");
            System.Threading.Thread.Sleep(1000);
        }
    }

    
}