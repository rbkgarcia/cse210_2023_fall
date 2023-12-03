//Address class
public class Address
{
    private string _Street;
    private string _City;
    private string _State;
    private int _PostalCode;
    private string _Country;

    //Address constructor
    public Address(string street, string city, string state, int postalCode, string country)
    {
        _Street = street;
        _City = city;
        _State = state;
        _PostalCode = postalCode;
        _Country = country;
    }
    //getters
    public string GetStreet()
    {
        return _Street;
    }
    public string GetCity()
    {
        return _City;
    }
    public string GetState()
    {
        return _State;
    }
    public int GetPostalCode()
    {
        return _PostalCode;
    }
    public string GetCountry()
    {
        return _Country;
    }
    //Settters
    public void SetStreet(string street)
    {
        _Street = street;
    }
    public void SetCity(string city)
    {
        _City = city;
    }
    public void SetState(string state)
    {
        _State = state;
    }
    public void SetPostalCode(int postalCode)
    {
        _PostalCode = postalCode;
    }
    public void SetCountry(string country)
    {
        _Country = country;
    }
    //display address
    public void DisplayAddress()
    {
        Console.WriteLine($"Address: {_Street}, {_City}, {_State}, {_PostalCode}, {_Country}");
    }
}