using System;

class Program
{
    static void Main(string[] args)
    {
        bool moreJournaling = true;
    
        Journal journal = new Journal();

        Console.WriteLine("Welcome to your journal.");
        
        do
            { 
                Console.WriteLine(""); 
                Console.WriteLine("What would you like to do?"); 
                Console.WriteLine("1. Write"); 
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Save");
                Console.WriteLine("4. Load");
                Console.WriteLine("5. Quit");
                int input = int.Parse(Console.ReadLine());

                if (input == 1) {
                    // Write
                    journal.AddToJournal();
                }
                else if (input == 2 ) {
                    // Display
                    journal.DisplayJournal();
                }
                else if (input == 3) {
                    // Save
                    journal.SaveToFile();
                }
                else if (input == 4) {
                    // Load
                    journal.LoadFromFile();
                }
                else if (input == 5) {
                    // Quit
                    moreJournaling = false;
                }

            }
        while(moreJournaling == true);

    }
}