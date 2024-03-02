using System;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;

        while (quit != true) {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            int input = int.Parse(Console.ReadLine());

            if (input == 1) {
                BreathingActivty breathing = new BreathingActivty();
                breathing.Play();
            }
            else if (input == 2) {
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.Play();
            }
            else if (input == 3) {
                ListingActivity listing = new ListingActivity();
                listing.Play(); 
            }
            else if (input == 4) {
                quit = true;
            }
        }


    }
}