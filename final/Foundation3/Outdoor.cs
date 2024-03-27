class Outdoor : Event
{
    private string _weather;

    public Outdoor(string title, string desc, string date, string time, Address address, string weather) : base(title, desc, date, time, address)
    {
        _type = "Outdoor";
        _weather = weather;
    }

    public override void FullDetails()
    {
        DisplayDetails();
        Console.WriteLine($"Forecast: {_weather}");
    }
}