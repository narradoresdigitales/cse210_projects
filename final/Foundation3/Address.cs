public class Address
{
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

    public string GetFullAddress()
    {
        return $"{StreetAddress}\n{City}, {StateOrProvince}\n{Country}";
    }

    public bool IsInUsa()
    {
        return Country.ToLower() == "usa" || Country.ToLower() == "united states";
    }

}