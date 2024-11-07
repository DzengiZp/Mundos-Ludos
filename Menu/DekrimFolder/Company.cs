public class Company
{
    public string CompanyName { get; set; } = null!;
    public decimal Money { get; set; }
    public int Employees { get; set; }
    public Dictionary<string, int> Products { get; set; }  
    public int LegacyPoints { get; set; } = 0; 

    public Company(string companyName, decimal money, int employees)
    {
        CompanyName = companyName;
        Money = money;
        Employees = employees;
        Products = new Dictionary<string, int>();
    }

    public void AddLegacyPoints(int points)
    {
        LegacyPoints += points;
        Console.WriteLine($"You've earned {points} Legacy Points! Total: {LegacyPoints}");
    }

    public void AddProduct(string productName, int quantity)
    {
        if (Products.ContainsKey(productName))
        {
            Products[productName] += quantity;
        }
        else
        {
            Products.Add(productName, quantity);
        }
    }

    public void LoseAllExceptMinimum()
    {
        Money = 1000m;
        Employees = 1;
        Products.Clear();
    }


    public void SpendMoney(decimal amount)
    {
        if (Money >= amount)
        {
            Money -= amount;
        }
        else
        {
            Console.WriteLine("Not enough money!");
        }
    }

    public void AddMoney(decimal amount)
    {
        Money += amount;
    }

    public Product GetProduct(string productName)
    {   
        if (Products.ContainsKey(productName)) 
        {
        
            if (productName == "Milk") return new DairyProduct("Milk", Products[productName], 1m, 2m);
            if (productName == "Butter") return new DairyProduct("Butter", Products[productName], 2m, 5m);
            if (productName == "Cheese") return new DairyProduct("Cheese", Products[productName], 7m, 15m);

            if (productName == "Toyota") return new CarProduct("Toyota", Products[productName], 10000m, 20000m);
            if (productName == "VW") return new CarProduct("VW", Products[productName], 20000m, 40000m);
            if (productName == "BMW") return new CarProduct("VW", Products[productName], 20000m, 40000m);
            if (productName == "Bugatti") return new CarProduct("VW", Products[productName], 20000m, 40000m);
            //
            if (productName == "Paracetamol") return new MedicineProduct("Paracetamol", Products[productName], 2m, 3m);
            if (productName == "Oxycodine") return new MedicineProduct("Oxycodine", Products[productName], 5m, 10m);
            if (productName == "Omeprazol") return new MedicineProduct("Omeprazol", Products[productName], 10m, 15m);
            if (productName == "Ozempic") return new MedicineProduct("Ozempic", Products[productName], 50m, 100m);

            if (productName == "Kiruna") return new RealEstateProduct("Kiruna", Products[productName], 100000m, 200000m);
            if (productName == "Stockholm") return new RealEstateProduct("Stockholm", Products[productName], 500000m, 1000000m);
            if (productName == "Madrid") return new RealEstateProduct("Madrid", Products[productName], 4000000m, 8000000m);
            if (productName == "Barcelona") return new RealEstateProduct("Barcelona", Products[productName], 3500000m, 7000000m);
            if (productName == "Marbella") return new RealEstateProduct("Marbella", Products[productName], 2000000m, 4000000m);
            if (productName == "New York") return new RealEstateProduct("New York", Products[productName], 5000000m, 1000000m);
            if (productName == "Los Angeles") return new RealEstateProduct("Los Angeles", Products[productName], 8000000m, 1600000m);
            
        }

        return null!;
    }

}
