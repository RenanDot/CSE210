using System;

public class BreathingActivity : Activity
{

    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
        
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Get ready...");
        ShowSpinner(5);

        Console.WriteLine("Breath in...");
        ShowCountdown(4);

        Console.WriteLine("Now breath out...");
        ShowCountdown(6);
    }
}