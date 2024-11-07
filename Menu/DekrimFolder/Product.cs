public abstract class Product
{
    public string Name { get; set; }
    public int Quantity { get; set; }
    public decimal BuyPrice { get; set; }
    public decimal SellPrice { get; set; }



    protected Product(string name, int quantity, decimal buyPrice, decimal sellPrice)
    {
        Name = name;
        Quantity = quantity;
        BuyPrice = buyPrice;
        SellPrice = sellPrice;
    }
}

public class DairyProduct : Product
{
    public DairyProduct(string name, int quantity, decimal buyPrice, decimal sellPrice)
        : base(name, quantity, buyPrice, sellPrice) { }
}

public class MedicineProduct : Product
{
    public MedicineProduct(string name, int quantity, decimal buyPrice, decimal sellPrice)
        : base(name, quantity, buyPrice, sellPrice) { }
}

public class CarProduct : Product
{
    public CarProduct(string name, int quantity, decimal buyPrice, decimal sellPrice)
        : base(name, quantity, buyPrice, sellPrice) { }
}

public class RealEstateProduct : Product
{
    public RealEstateProduct(string name, int quantity, decimal buyPrice, decimal sellPrice)
        : base(name, quantity, buyPrice, sellPrice) { }
}

