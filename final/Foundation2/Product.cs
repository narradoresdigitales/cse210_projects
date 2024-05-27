using System.Numerics;
using Microsoft.VisualBasic;

public class Product
{
    // Contains the name, product id, price, and quantity of each product.


    // Set attributes  // Encapsulate attributes with Getters/Setters
    public string ProductName {get; private set;}
    public string ProdID {get; private set;}
    public double ProdPrice {get; private set;}
    public int Quantity {get; private set;}


    public Product(string product, string productID, double price, int quantity)
    {
        ProductName = product;
        ProdID = productID;
        ProdPrice = price;
        Quantity = quantity;
    }

    

    // The total cost of this product is computed by multiplying the price per unit and the quantity. 
    // (If the price per unit was $3 and they bought 5 of them, the product total cost would be $15.)
    public double GetTotalCost()
    {
       return Math.Round(ProdPrice * Quantity, 2);
        
    }

    
    
}