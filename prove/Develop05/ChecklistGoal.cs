class ChecklistGoal : Goal
{

    private int _accomp;
    private int _bonus;
    private int _numComplete;

    public ChecklistGoal() : this("", "", 0, 0, 0, 0)
    {

    }

    public ChecklistGoal(string name, string desc, int pts, int accomp, int bonus, int complete) : base(name, desc, pts)
    {
       _accomp = accomp;
       _bonus = bonus;
       _numComplete = complete;
    }
    
    public override string CreateGoal()
    {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        _desc = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        _pts = int.Parse(Console.ReadLine());

        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _accomp = int.Parse(Console.ReadLine());

        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonus = int.Parse(Console.ReadLine());

        // When it's created, there will be none complete
        _numComplete = 0;

        return GetStringRepresentation();
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_name},{_desc},{_pts},{_accomp},{_bonus},{_numComplete}";
    }

    public override int RecordEvent(int score, string text)
    {
        // Remove the prefix
        string[] parts = text.Substring("ChecklistGoal:".Length).Split(',');

        // Get components
        int pts = int.Parse(parts[2]);
        int accomp = int.Parse(parts[3]);
        int bonus = int.Parse(parts[4]);
        int numComplete = int.Parse(parts[5]);

        numComplete++;
        Console.WriteLine($"Congratulations! You have earned {pts} points!");

        // Check to see if a bonus needs to be applied
        if (numComplete == accomp)
        {
            // If the number completed is the same as needed to be accomplished
            score += pts;
            score += bonus;
        }
        else
        {
            score += pts;
        }

        return score;
    }

    public string CompleteTask(string text)
    {
        // Remove the prefix
        string[] parts = text.Substring("ChecklistGoal:".Length).Split(',');

        // Get parts
        string name = parts[0];
        string desc = parts[1];
        int pts = int.Parse(parts[2]);
        int accomp = int.Parse(parts[3]);
        int bonus = int.Parse(parts[4]);
        int numComplete = int.Parse(parts[5]);
        
        // If they have accomplished all of the needed to be accomplished, reset the num complete
        if (numComplete == accomp)
        {
            numComplete = 0;
        }
        else
        {
            numComplete++;
        }

        return $"ChecklistGoal:{name},{desc},{pts},{accomp},{bonus},{numComplete}";
    }

    public override void Display(string text, string description = "y")
    {
        // Remove the prefix
        string [] parts = text.Substring("ChecklistGoal:".Length).Split(',');

        // Get parts needed
        string name = parts[0];
        string desc = parts[1];
        int accomp = int.Parse(parts[3]);
        int numComplete = int.Parse(parts[5]);

        if (description == "n")
        {
            if (numComplete == accomp)
            {
                Console.Write($"{name}");
            }
            else
            {
                Console.Write($"{name}");
            }
        }
        else {        
            if (numComplete == accomp)
            {
                Console.Write($"[X] {name} ({desc}) --- Currently completed: {numComplete}/{accomp}");
            }
            else
            {
                Console.Write($"[ ] {name} ({desc}) --- Currently completed: {numComplete}/{accomp}");
            }
        }

    }
}