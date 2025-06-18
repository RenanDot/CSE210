using System;

public class BreathingActivity : Activity
{

    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing")
    {
        
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.Clear();

        Console.WriteLine("Get ready...");
        ShowSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {

            Console.Write("Breath in...");
            Console.WriteLine();
            ProgressBar(4, 1000);

            Console.Write("Now breath out...");
            Console.WriteLine();
            InverseProgressBar(6, 1000);

            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}