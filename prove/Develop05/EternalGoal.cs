class EternalGoal : Goal 
{
    public EternalGoal(string name, string desc, int pts) : base(name, desc, pts)
    {
   
    }

    public EternalGoal() : this("", "", 0)
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

        return GetStringRepresentation();
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_name},{_desc},{_pts}";
    }

    public override int RecordEvent(int score, string text)
    {
        // Remove the prefix
        string[] parts = text.Substring("EternalGoal:".Length).Split(',');

        // Get parts
        int pts = int.Parse(parts[2]);

        Console.WriteLine($"Congratulations! You have earned {pts} points!");

        score += pts;

        return score;
    }

    public override void Display(string text, string description = "y")
    {
        // Remove the prefix
        string[] parts = text.Substring("EternalGoal:".Length).Split(',');

        // Get parts needed
        string name = parts[0];
        string desc = parts[1];

        if (description == "n")
        {
            Console.Write($"{name}");
        }
        else 
        {
            Console.Write($"[ ] {name} ({desc})");
        }
    }

}