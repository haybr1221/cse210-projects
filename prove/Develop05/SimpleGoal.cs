class SimpleGoal : Goal
{
    private bool _complete;

    public SimpleGoal(string name, string desc, int pts, bool complete) : base(name, desc, pts)
    {
        _complete = complete;
    }

    public SimpleGoal() : this("", "", 0, false)
    {

    }

    public override string CreateGoal()
    {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        _desc = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        _pts = int.Parse(Console.ReadLine());

        // When created, it will not be completed
        _complete = false;

        return GetStringRepresentation();
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_name},{_desc},{_pts},{_complete}";
    }

    public override int RecordEvent(int score, string text)
    {
        // Remove the prefix
        string[] parts = text.Substring("SimpleGoal:".Length).Split(',');

        // Get components
        int pts = int.Parse(parts[2]);
        bool isComplete = bool.Parse(parts[3]);

        if (isComplete == true)
        {
            Console.WriteLine("You have already completed this goal!");
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {pts} points!");
            score += pts;
        }

        return score;
    }

    public string MarkComplete(string text)
    {
        // Remove the prefix
        string[] parts = text.Substring("SimpleGoal:".Length).Split(',');

        // Get needed parts
        string name = parts[0];
        string desc = parts[1];
        int pts = int.Parse(parts[2]);
        
        // Mark as complete
        _complete = true;

        return $"SimpleGoal:{name},{desc},{pts},{_complete}";
    }

    public override void Display(string text, string description = "y")
    {
        // Remove the prefix
        string [] parts = text.Substring("SimpleGoal:".Length).Split(',');

        // Get needed parts
        string name = parts[0];
        string desc = parts[1];
        bool isComplete = bool.Parse(parts[3]);

        if (description == "n")
        {
            if (isComplete == true)
            {
                Console.Write($"{name}");
            }
            else
            {
                Console.Write($"{name}");
            }
        }
        else
        {
            if (isComplete == true)
            {
                Console.Write($"[X] {name} ({desc})");
            }
            else
            {
                Console.Write($"[ ] {name} ({desc})");
            }
        }

    }
}