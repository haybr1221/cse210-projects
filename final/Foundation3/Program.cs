using System;

class Program
{
    static void Main(string[] args)
    {
        // New address
        Address a1 = new Address("1456 Elm Street", "Rexburg", "ID", "United States");
        // New event
        Lectures lecture = new Lectures("Introduction to Programming", 
        "Join in and learn to program with a simple, beginner-friendly and interactive lecture", "April 22, 2024", "7:00 PM", a1, "John Doe", 50);

        // Display methods for lecture
        lecture.DisplayDetails();
        Console.WriteLine();
        lecture.FullDetails();
        Console.WriteLine();
        lecture.ShortDescription();
        Console.WriteLine();

        // New address
        Address a2 = new Address("456 Elm St", "Metropolis", "NY", "United States");
        Outdoor outdoor = new Outdoor("Advanced Quantum Mechanics Symposium", "A comprehensive discussion on advanced topics in quantum mechanics", "May 15, 2024", "2:00 PM", a2, "Partly cloudy with a chance of showers");

        // Display methods for outdoors
        outdoor.DisplayDetails();
        Console.WriteLine();
        outdoor.FullDetails();
        Console.WriteLine();
        outdoor.ShortDescription();
        Console.WriteLine();

        // New address
        Address a3 = new Address("789 Oak St", "Springfield", "CA", "United States");
        Receptions reception = new Receptions("Annual Charity Gala Dinner", "An elegant evening of fine dining and fundraising for local charities", "April 15, 2024", "7:00 PM", a3, "janesmith@gmail.com");

        // Display methods for outdoors
        reception.DisplayDetails();
        Console.WriteLine();
        reception.FullDetails();
        Console.WriteLine();
        reception.ShortDescription();
        Console.WriteLine();
    }
}