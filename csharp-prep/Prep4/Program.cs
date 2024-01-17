using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers. Enter 0 to stop.");
        int sum = 0;
        int entry = -1;

        while (entry != 0) {
            Console.WriteLine("Enter a number: ");
            entry = int.Parse(Console.ReadLine());

            numbers.Add(entry);
            sum += entry;
        }

        // Define a num to make a max 
        int max = -1;

        // See which in the list is the highest
        foreach (int number in numbers)
        {
            if (number > max) {
                max = number;
            }
        }
        
        // Find the average
        float average = ((float)sum) / (numbers.Count - 1);

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}