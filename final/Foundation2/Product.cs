//Product class
public class Product
{
    private string _Name;
    private double _Price;
    private int _Quantity;
    private int _ID;
    //Product constructor

    public Product(string name, double price, int quantity, int id)
    {
        _Name = name;
        _Price = price;
        _Quantity = quantity;
        _ID = id;
    }
    //Setters
    public void SetName(string name)
    {
        _Name = name;
    }
    public void SetPrice(double price)
    {
        _Price = price;
    }
    public void SetQuantity(int quantity)
    {
        _Quantity = quantity;
    }
    public void SetID(int id)
    {
        _ID = id;
    }
    //Getters
    public string GetName()
    {
        return _Name;
    }
    public double GetPrice()
    {
        return _Price;
    }
    public int GetQuantity()
    {
        return _Quantity;
    }
    public int GetID()
    {
        return _ID;
    }
    //Total Price
    public double TotalPrice()
    {
        return _Price * _Quantity;
    }
}
