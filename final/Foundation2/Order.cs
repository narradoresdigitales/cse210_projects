using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
public class Order
{

//need list of products 
public List<Product> Products {get; private set; } = new List<Product>();
public Customer Customer {get; private set;}

//need list of customers
public Order(Customer customer)
{
    Customer = customer;
}


//method to add a product to the order
public void AddProduct(Product product)
{
    Products.Add(product);
}


//method to calculate the total cost of the order

    //total price is calculated as the sum of the total cost of each product plus a one-time shipping cost
    //This company is based in the USA. If the customer lives in the USA, then the shipping cost is $5. If the customer does not live in the USA, then the shipping cost is $35.

    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (var product in Products)
        {
            totalCost += product.CalculateTotalCost();
        }

        if (!Customer.IsInUSA())
        {
            totalCost += 15;
        }

        return totalCost;
    }

//return string for the packing label

    //A packing label should list the name and product id of each product in the order.

    public void DisplayOrderDetails()
    {
        Console.WriteLine("Order Details:");
        foreach (var product in Products)
        {
            Console.WriteLine($"{product.ProductName}) ({product.ProdID} x {product.Quantity} = ${product.CalculateTotalCost()}");
        }
    
    //return string for the shipping label
    //A shipping label should list the name and address of the customer
    Console.WriteLine($"Customer: {Customer.Name}");
    Console.WriteLine($"Shipping Address \n {Customer.Address.GetFullAddress()}"); 
    Console.WriteLine($"Total Cost: ${CalculateTotalCost()}");

    }

}