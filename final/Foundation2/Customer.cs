public class Customer
{

    //The customer contains a name and an address.

    public string Name {get; private set;}
     //The name is a string, but the Address is a class.
    public Address Address {get; private set;}

    public Customer(string name, Address address)
    {
        Name = name;
        Address = address;
    }

    //The customer should have a method that can return whether they live in the USA or not. 
    //(Hint this should call a method on the address to find this.)

    public bool IsInUSA()
    {
        return Address.IsInUsa();
    }
    
}