abstract class Exercise
{
    private string _date;

    private int _length;

    public string date {get {return _date;}}

    public int length {get {return _length;}}

    public Exercise(string date, int length)
    {
        _date = date;
        _length = length;
    }

    public virtual double GetDistance()
    {
        return 0;
    }
    
    public virtual double GetSpeed()
    {
        return 0;
    }
    
    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetActivity()
    {
        return "";
    }

    public void GetSummary()
    {
        double dist = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();
        string activity = GetActivity();

        Console.WriteLine($"{date} {activity} ({length} min): Distance: {dist} km, Speed: {speed} kph, Pace: {pace} min per km");
    }
}