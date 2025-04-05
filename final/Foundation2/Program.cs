using System;

namespace OnlineOrdering
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create first order
            Address address1 = new Address("123 Main St", "New York", "NY", "USA");
            Customer customer1 = new Customer("Alice Johnson", address1);
            Order order1 = new Order(customer1);
            order1.AddProduct(new Product("Laptop", "LAP123", 999.99m, 1));
            order1.AddProduct(new Product("Mouse", "MOU456", 25.50m, 2));

            // Create second order
            Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
            Customer customer2 = new Customer("Bob Smith", address2);
            Order order2 = new Order(customer2);
            order2.AddProduct(new Product("Smartphone", "PHN789", 699.99m, 1));
            order2.AddProduct(new Product("Headphones", "HDP012", 89.99m, 1));
            order2.AddProduct(new Product("Charger", "CHR345", 19.99m, 1));

            // Display order details
            Console.WriteLine("Order 1:");
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}\n");

            Console.WriteLine("Order 2:");
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}\n");
        }
    }
}