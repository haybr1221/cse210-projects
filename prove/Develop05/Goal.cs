public abstract class Goal 
{
    protected string _name;

    protected string _desc;

    protected int _pts;

    protected Goal(string name, string desc, int pts)
    {
        _name = name;
        _desc = desc;
        _pts = pts;
    }

    public abstract string CreateGoal();

    public abstract string GetStringRepresentation();

    public abstract int RecordEvent(int score, string text);

    public abstract void Display(string text, string description = "y");

}