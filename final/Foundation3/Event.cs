abstract class Event
{
    protected string _title;

    protected string _desc;

    protected string _date;

    protected string _time;

    protected Address _addy;

    protected string _type;

    public Address address {get {return _addy;}}

    protected Event(string title, string desc, string date, string time, Address address)
    {
        _title = title;
        _desc = desc;
        _date = date;
        _time = time;
        _addy = address;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"{_title}");
        Console.WriteLine($"{_desc}");
        Console.WriteLine($"{_date} - {_time}");
        Console.WriteLine($"{address.FormatAddy()}");

    }

    public abstract void FullDetails();

    public void ShortDescription()
    {
        Console.WriteLine($"{_type}");
        Console.WriteLine($"{_title} on {_date}");
    }

}