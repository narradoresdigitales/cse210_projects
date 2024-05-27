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
        bool isInUsa = address1.IsInUSA();
        Console.WriteLine($"Is in USA: {isInUSA}");

        string fullAddress = address1.GetFullAddress();
        Console.WriteLine("Full Address:");
        Console.WriteLine(fullAddress);



    }
}