using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Marcus, Foundation2 World!");
        Console.WriteLine();

        Product prod1 = new Product("Apple", "A001", 1.50,  2);
        Product prod2 = new Product("Banana", "B001", 1.00,  3);
        Product prod3 = new Product("Orange", "O001", 2.50,  5);
        Product prod4 = new Product("Pear", "P001", 1.75,  2);
        Product prod5 = new Product("Almonds", "A002", 5.00,  2);
    

        Address address1 = new Address("123 Main St", "Happy Town", "Texas", "USA");
        Address address2 = new Address("123 Calle Main", "Good Winds", "Buenos Aires", "ARG");
        
        Customer customer1 = new Customer("Marcus Palmer", address1);
        Customer customer2 = new Customer("Silvano Palmer", address2);
        
        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);
        
        order1.AddProduct(prod1);
        order1.AddProduct(prod2);
        order1.AddProduct(prod3);
        Console.WriteLine("Order 1 Details:");
        order1.DisplayOrderDetails();
        Console.WriteLine($"Total Cost for Order 1: ${order1.CalculateTotalCost():F2}");
        
        Console.WriteLine();
        order2.AddProduct(prod4);
        order2.AddProduct(prod5);
        Console.WriteLine("Order 2 Details:");
        order2.DisplayOrderDetails();
        Console.WriteLine($"Total Cost for Order 2: ${order2.CalculateTotalCost():F2}");
        
        

    }
}