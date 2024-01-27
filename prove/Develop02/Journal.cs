using System.IO; 


public class Journal {

    public string _datePrompt;

    public string _input;
    public List<string> _journal = new List<string>();
    
    public void AddToJournal() {
        Entry journalEntry = new Entry();
        _datePrompt = journalEntry.Display();
        Console.WriteLine($"{_datePrompt}");
        _input = Console.ReadLine();
        _journal.Add($"{_datePrompt}\n{_input}");
    }

    public void DisplayJournal() {
        // Display the file. Display all journal entries currently in the journal
        for (int i = 0; i < _journal.Count; i++) {
            Console.WriteLine($"\n{_journal[i]}");
        }
    }

    public void SaveToFile() {
        // Save to file. Prompt for filename and then save to that file location
        Console.WriteLine($"\nName of output file:");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename)) {
            for (int i = 0; i < _journal.Count; i++) {
                outputFile.WriteLine($"{_journal[i]}|");
            }
        }

        Console.WriteLine($"\nFile has been saved.");
    }

    public void LoadFromFile() {
        // Load from file. Should replace the entries currently stored in the journal
        Console.WriteLine($"\nName of the input file:");
        string filename = Console.ReadLine();

        // Clear the list
        _journal.Clear();

        string [] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines) {
            string[] parts = line.Split("|");
            string entry = parts[0];
            _journal.Add(entry);
        }

        Console.WriteLine("\nFile has been loaded.");
    }
}