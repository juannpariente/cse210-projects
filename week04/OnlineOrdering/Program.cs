using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("742 Evergreen Terrace", "Springfield", "IL", "USA");
        Address address2 = new Address("50 George St", "Sydney", "NSW", "Australia");

        Customer customer1 = new Customer("Mike Smith", address1);
        Customer customer2 = new Customer("Emily Rose", address2);

        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        order1.AddProduct(new Product("Apple MacBook Pro 16", 1001, 2499, 2));
        order1.AddProduct(new Product("Sony A7 IV Camera", 2045, 3499, 1));
        order1.AddProduct(new Product("Bose Noise Cancelling Headphones 700", 3098, 379, 3));
        order2.AddProduct(new Product("Samsung 85 QLED 8K TV", 4123, 4999, 1));
        order2.AddProduct(new Product("DJI Mavic 3 Drone", 5237, 2199, 1));
        order2.AddProduct(new Product("Leica M10-R Camera", 7890, 7999, 1));

        Console.WriteLine("----------Packing Label----------");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine("---------------------------------");
        Console.WriteLine("----------Shipping Label---------");
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine("---------------------------------");
        Console.WriteLine($"Total Price: ${order1.TotalPrice()}");

        Console.WriteLine();

        Console.WriteLine("----------Packing Label----------");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine("---------------------------------");
        Console.WriteLine("----------Shipping Label---------");
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine("---------------------------------");
        Console.WriteLine($"Total Price: ${order2.TotalPrice()}");
    }
}