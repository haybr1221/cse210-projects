class Swimming : Exercise
{
    private int _laps;

    public Swimming(string date, int length, int laps) : base(date, length)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * 50) / 1000;
    }

    public override double GetSpeed()
    {
        return (_laps * 50 / 1000) * 60;
    }

    public override double GetPace()
    {
        return length / (_laps * 50 / 1000);
    }

    public override string GetActivity()
    {
        return "Swimming";
    }

}