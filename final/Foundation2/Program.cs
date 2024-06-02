using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        // Create a variety of products
        Product bananas = new Product("bananas", "BANA", .54, 3);
        Product toothbrushes = new Product("toothbrushes", "TBRU", 1.45, 3);
        Product flour = new Product("flour", "FLOR", 3.99, 2);
        Product sugar = new Product("sugar", "SGAR", 3.99, 4);
        Product cereal = new Product("cereal", "CERL", 2.99, 6);
        Product pasta = new Product("pasta", "PSTA", 1.99, 7);

        // Create the addresses
        Address jAddress = new Address("1234 Somewhere st", "Somewhere", "TX", "USA");
        Address bAddress = new Address("5678 Algun Lugar Calle", "Chihuahua", "Chihuahua", "Mexico");
        Address rAddress = new Address("7890 Here blvd", "There", "AZ", "USA");

        // Create the customers
        Customer john = new Customer("John Smith", jAddress);
        Customer beatriz = new Customer("Beatriz Lopez", bAddress);
        Customer rodrigo = new Customer("Rodrigo Gomez", rAddress);

        // Order 1
        Order jOrder = new Order([flour, sugar, cereal], john);
        Order bOrder = new Order([pasta, toothbrushes, bananas], beatriz);
        Order rOrder = new Order([pasta, flour, bananas], rodrigo);
        List<Order> orders = [jOrder, bOrder, rOrder];

        // Display order info
        foreach (Order order in orders)
        {
            Console.WriteLine(order.PackingLabel());
            Console.WriteLine(order.ShippingLabel());
            Console.WriteLine($"${order.ComputeTotalCost()}\n");
        }
    }
}