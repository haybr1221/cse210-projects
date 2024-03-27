class Product
{
    private string _productName;

    private int _productId;

    private int _pricePerUnit;

    private int _qty;

    public string productName { get {return _productName;}}
    public int productId { get {return _productId;}}

    public Product(string name, int id, int price, int qty)
    {
        _productName = name;
        _productId = id;
        _pricePerUnit = price;
        _qty = qty;
    }

    public decimal GetPrice()
    {
        return _pricePerUnit * _qty;
    }
}