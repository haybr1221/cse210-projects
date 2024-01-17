using System;
// Write a program that determines the letter grade for a course according to the following scale

// A >= 90
// B >= 80
// C >= 70
// D >= 60
// F < 60

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your percent? ");
        string entry = Console.ReadLine();
        int percent = int.Parse(entry);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else if (percent < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (percent >= 70)
        {
            Console.WriteLine("Congrats! You passed!");
        }
        else 
        {
            Console.WriteLine("Sorry, you didn't pass... better luck next time.");
        }
    }
}