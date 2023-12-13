//Order class
using System.Reflection.Emit;

public class Order
{
    private Customer _Client;
    private List<Product> _Products = new List<Product>();
    private double _Total = 0;
    //Constructor
    public Order(Customer client)
    {
        _Client = client;
    }
    //Getters
    public Customer GetClient()
    {
        return _Client;
    }
    public List<Product> GetProducts()
    {
        return _Products;
    }
    public double GetTotal()
    {
        //local variable that will be recomputed when called method
        double total = 0;
        foreach (Product product in _Products)
        {
            total += product.GetPrice();
        }
        return total;
    }
    //Setters
    public void SetClient(Customer client)
    {
        _Client = client;
    }
    public void SetProducts(List<Product> products)
    {
        _Products = products;
    }
    public void SetTotal(double total)
    {
        _Total = total;
    }
    //Packing Label
    public String GeneratePackingLabel()
    {
        string label ="";
        foreach (Product product in _Products)
        {
            label+=($"\n- " + product.GetName() + " - Quantity: "  + product.GetQuantity()+" - Price: $" + product.GetPrice().ToString("0.##"));
        }
        label+= ($"\n- Total: ${GetTotal().ToString("0.##")}");
        return label;
    }
    //Shipping Label
    public string GenerateShippingLabel(){
        string label ="";
        label+= ($"\n- Name: " + _Client.GetName() + " - Address: " + _Client.GetCustomerAddress().FullAddress());
        return label;
    }
}