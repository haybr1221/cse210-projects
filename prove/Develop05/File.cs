using System.IO;
class File
{
    public void SaveGoals(int score, List<string> list)
    {
        Console.Write("What is the name of the file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(score);
            foreach (string i in list)
            {
                outputFile.WriteLine(i);
            }
        }
    }

    public int LoadGoals(List<string> list)
    {
        Console.Write("What is the name of the file? ");
        string fileName = Console.ReadLine();

        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            int score = int.Parse(reader.ReadLine());
            while ((line = reader.ReadLine()) != null)
            {
                if (line.StartsWith("SimpleGoal:"))
                {
                    // Remove the prefix
                    string[] parts = line.Substring("SimpleGoal:".Length).Split(',');

                    // Extract the individual components
                    string name = parts[0];
                    string desc = parts[1];
                    int pts = int.Parse(parts[2]);
                    bool complete = bool.Parse(parts[3]);

                    // Create a new object
                    SimpleGoal simple = new SimpleGoal(name, desc, pts, complete);
                    list.Add(simple.GetStringRepresentation());
                }
                else if (line.StartsWith("EternalGoal:"))
                {
                    // Remove the prefix
                    string[] parts = line.Substring("EternalGoal:".Length).Split(',');

                    string name = parts[0];
                    string desc = parts[1];
                    int pts = int.Parse(parts[2]);

                    // Create a new object
                    EternalGoal eternal = new EternalGoal(name, desc, pts);
                    list.Add(eternal.GetStringRepresentation());
                }
                else if (line.StartsWith("ChecklistGoal:"))
                {
                    // Remove the prefix
                    string[] parts = line.Substring("ChecklistGoal:".Length).Split(',');

                    string name = parts[0];
                    string desc = parts[1];
                    int pts = int.Parse(parts[2]);
                    int accom = int.Parse(parts[3]);
                    int bonus = int.Parse(parts[4]);
                    int completed = int.Parse(parts[5]);

                    // Create a new object
                    ChecklistGoal checklist = new ChecklistGoal(name, desc, pts, accom, bonus, completed);
                    list.Add(checklist.GetStringRepresentation());
                }
            }
            return score;
        }
    }
}