public class Address
{

    //The address contains a string for the street address, the city, state/province, and country.
    public string StreetAddress {get; private set;}
    public string City {get; private set;}
    public string StateOrProvince {get; private set;}
    public string Country {get; private set;}

    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        StreetAddress = streetAddress;
        City = city;
        StateOrProvince = stateOrProvince;
        Country = country;
    }

        // The address should have a method that can return whether it is in the USA or not.

    public bool IsInUsa()
    {
        return Country.ToLower() == "usa" || Country.ToLower() == "united states";
    }

    // The address should have a method to return a string all of its fields together in one string (with newline characters where appropriate)
    
    public string GetFullAddress()
    {
        return $"{StreetAddress}\n{City}, {StateOrProvince}\n{Country}";
    }


}