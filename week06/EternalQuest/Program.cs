/*
    Code written by: Renan Daniel de Campos

    As part of exceeding requirements, I created a way to save
    the file by adding lines to the file (if the file already exists)
    or creating a new file (if the file does not exist). It also
    increments the score at the file. I also added a function to
    the Checking Goals, where you can continue completing the goal
    and receive the bonus if the amount of complete goals is a multiple
    of the target.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to your manager of goals!");

        GoalManager goalManager = new GoalManager();

        while (true)
        {
            goalManager.Start();
        }    
    }
}