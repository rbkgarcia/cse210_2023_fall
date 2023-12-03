using System;

class Program
{
    static void Main(string[] args)
    {
        //first order
        Address address1 = new Address("Las Acacias", "Caracas", "Capital District", 1050, "Venezuela");
        Customer customer1 = new Customer("Rebeca", address1);
        
        
        Order order1 = new Order(customer1);

        Product product1 = new Product("Apple", 0.99, 5, 1);
        Product product2 = new Product("Orange", 0.99, 5, 2);
        Product product3 = new Product("Banana", 0.99, 5, 3);
        order1.SetProducts(new List<Product> { product1, product2, product3 });
        
        //second order
        Address address2 = new Address("Los Ilustres", "Caracas", "Capital District", 1050, "Venezuela");
        Customer customer2 = new Customer("Gabriel", address1);
        Order order2 = new Order(customer2);
        Product product4 = new Product("Grape", 0.99, 5, 4);
        Product product5 = new Product("Pear", 0.99, 5, 5);
        Product product6 = new Product("Kiwi", 0.99, 5, 6);
        order2.SetProducts(new List<Product> { product1, product2, product3 });

        Console.WriteLine("Packing Label Order 1: {order1.Generateabel()}");
        Console.WriteLine("Shipping Label Order 1: {order1.GenerateShippingLabel()}");
        Console.WriteLine("Packing Label Order 2: {order2.GeneratePackingLabel()}");
        Console.WriteLine("Shipping Label Order 2: {order2.GenerateShippingLabel()}");

    }
}