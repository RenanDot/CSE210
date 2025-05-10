using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        int numb = -1;
        while (numb != 0)
        {
            Console.Write("Enter number: ");
            numb = int.Parse(Console.ReadLine());

            if (numb != 0)
            {
                numbers.Add(numb);
            }
        }

        int sum = 0;
        int largest = 0;
        foreach (int number in numbers)
        {
            sum += number;
            if (number > largest)
            {
                largest = number;
            }
        }

        Console.WriteLine("The sum is: " + sum);
        Console.WriteLine("The average is: " + (double)sum / numbers.Count);
        Console.WriteLine("The largest number is: " + largest);

    }
}