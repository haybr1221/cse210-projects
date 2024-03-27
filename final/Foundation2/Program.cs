using System;

class Program
{
    static void Main(string[] args)
    {
        // Products
        Product p1 = new Product("Treehouse", 1, 250, 1);
        Product p2 = new Product("Laptop", 2, 300, 1);
        Product p3 = new Product("Headphones", 3, 20, 2);

        // Address and Customer
        Address a1 = new Address("50 E North Temple St", "Salt Lake City", "Utah", "United States");
        Customer c1 = new Customer("Russel M. Nelson", a1);

        // Order
        Order o1 = new Order();
        o1.customer = c1;
        o1.products.Add(p1);
        o1.products.Add(p2);
        o1.products.Add(p3);

        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(o1.ShippingLabel());
        Console.WriteLine("\nPacking Label:");
        Console.WriteLine(o1.PackingLabel());
        Console.WriteLine("Total Cost:");
        Console.WriteLine($"${o1.TotalCost()}");

        // Products
        Product p4 = new Product("Fish food", 4, 15, 5);
        Product p5 = new Product("Scuba mask", 5, 75, 1);

        // Addres and Customer
        Address a2 = new Address("42 Wallaby Way", "Sydney", "New South Wales", "Australia");
        Customer c2 = new Customer("Nemo", a2);

        // Order
        Order o2 = new Order();
        o2.customer = c2;
        o2.products.Add(p4);
        o2.products.Add(p5);

        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(o2.ShippingLabel());
        Console.WriteLine("\nPacking Label:");
        Console.WriteLine(o2.PackingLabel());
        Console.WriteLine("Total Cost:");
        Console.WriteLine($"${o2.TotalCost()}");
    }
}