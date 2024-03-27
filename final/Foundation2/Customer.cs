class Customer
{
    private string _name;

    private Address _address;

    public string name {get {return _name;}}
    
    public Address address {get {return _address;}}

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public void GetLocation()
    {
        bool countryCheck = _address.IsInUSA();

        if (countryCheck == true)
        {
            Console.WriteLine($"{_name} lives in the USA");
        }
        else
        {
            Console.WriteLine($"{_name} does not live in the USA");
        }
    }
}