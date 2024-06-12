namespace ToString.Models;

public class Product
{
    private string _name;
    private double _price;
    private int _quantity;

    public string Name => _name;
    public double Price => _price;

    public int Quantity
    {
        get { return _quantity; }
        set { _quantity = value; }
    }

    public Product(string name, double price, int quantity)
    {
        _name = name;
        _price = price;
        _quantity = quantity;
    }

    public void IncreaseProductQuantity(int quantity)
    {
        Quantity += quantity;
        Console.WriteLine($"New Quantity: {Quantity}");
    }

    public void DecreaseProductQuantity(int quantity)
    {
        Quantity -= quantity;
        Console.WriteLine($"New Quantity: {Quantity}");
    }

    public double TotalValue()
    {
        return Quantity * Price;
    }

    public override string ToString()
    {
        return "Name:" + Name + "\nPrice: " + Price + "\nQuatity: " + Quantity;
    }
}