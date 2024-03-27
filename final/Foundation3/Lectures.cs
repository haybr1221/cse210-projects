class Lectures : Event
{
    private string _speaker;

    private int _capacity;

    public Lectures(string title, string desc, string date, string time, Address address, string speaker, int capacity) : base(title, desc, date, time, address)
    {
        _type = "Lecture";
        _speaker = speaker;
        _capacity = capacity;
    }

    public override void FullDetails()
    {
        DisplayDetails();
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Capacity: {_capacity}");
    }
}