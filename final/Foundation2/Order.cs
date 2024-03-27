class Order
{
    public List<Product> products = new List<Product> {};

    public Customer customer;

    public decimal TotalCost()
    {
        // Sum of each product plus shipping cost
        decimal total = 0;
        foreach (Product p in products)
        {
            total += p.GetPrice();
        }

        // Calculate shipping cost
        bool checkCountry = customer.address.IsInUSA();

        if (checkCountry == true)
        {
            // Lives in USA, so add $5 for shipping
            total += 5;
        }
        else
        {
            // Does not live in USA, so add $35 for shipping
            total += 35;
        }

        return total;
    }

    public string ShippingLabel()
    {
        // Name and address of the customer
        return $"{customer.name}\n{customer.address.FormatAddy()}";
    }

    public string PackingLabel()
    {
        // Name and product id of each item
        string productInfo = "";

        foreach (Product p in products)
        {
            productInfo += $"{p.productName} (ID: {p.productId})\n";
        }

        return productInfo;
    }

}