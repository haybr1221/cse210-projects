class Bike : Exercise
{
    private int _speed;

    public Bike(string date, int length, int speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return length * (60 / _speed);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override string GetActivity()
    {
        return "Biking";
    }

}