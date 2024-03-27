class Receptions : Event
{

    private string _email;

    public Receptions(string title, string desc, string date, string time, Address address, string email) : base(title, desc, date, time, address)
    {
        _type = "Reception";
        _email = email;
    }

    public override void FullDetails()
    {
        DisplayDetails();
        Console.WriteLine($"RSVP here: {_email}");
    }
}