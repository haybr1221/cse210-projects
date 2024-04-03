class Running : Exercise
{

    private int _dist;

    public Running(string date, int length, int dist) : base(date, length)
    {
        _dist = dist;
    }

    public override double GetDistance()
    {
        return _dist;
    }

    public override double GetSpeed()
    {
        return ((double)_dist / length) * 60;
    }

    public override double GetPace()
    {
        return length / _dist;
    }
    
    public override string GetActivity()
    {
        return "Running";
    }
}