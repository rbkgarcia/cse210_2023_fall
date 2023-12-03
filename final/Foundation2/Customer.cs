//Costumer class
public class Customer
{
    private string _Name;
    private Address _CostumerAddress;
    //Costumer Constructor
    public Customer(string name, Address address)
    {
        _Name = name;
        _CostumerAddress = address;
    }
    //Setters
    public void SetName(string name)
    {
        _Name = name;
    }
    public void SetCustomerAddress(Address address)
    {
        _CostumerAddress = address;
    }
    //Getters
    public string GetName()
    {
        return _Name;
    }
    public Address GetCustomerAddress()
    {
        return _CostumerAddress;
    }
}