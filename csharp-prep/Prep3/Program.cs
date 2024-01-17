using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        int guess = 0;

        Console.WriteLine("What is the magic number? ");
        string entry = Console.ReadLine();
        int magicNumber = int.Parse(entry);

        while (guess != magicNumber)
        {

            Console.WriteLine("What is your guess? ");
            string guessEntry = Console.ReadLine();
            guess = int.Parse(guessEntry);

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("That's it!");
            }
        } 


    }
}