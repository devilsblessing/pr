using System;

class Package
{
    public string Description { get; private set; }
    public double Weight { get; private set; }

    public Package(string description, double weight)
    {
        Description = description;
        Weight = weight;
    }
}

class ShippingService
{
    public double WeightLimit { get; private set; }
    private double totalWeightShipped;

    public ShippingService(double weightLimit)
    {
        WeightLimit = weightLimit;
        totalWeightShipped = 0;
    }

    public void SendPackage(Package package)
    {
        if (totalWeightShipped + package.Weight <= WeightLimit)
        {
            Console.WriteLine($"Посылка отправлена: {package.Description}, Вес: {package.Weight} кг");
            totalWeightShipped += package.Weight;
        }
        else
        {
            Console.WriteLine("Ошибка: Превышен лимит веса отправленных посылок.");
        }
    }
}

class PostOffice
{
    static void Main()
    {
        ShippingService shippingService = new ShippingService(20); 
        
        Package package1 = new Package("Книги", 7);
        Package package2 = new Package("Одежда", 5);
        Package package3 = new Package("Электроника", 10);

        shippingService.SendPackage(package1);
        shippingService.SendPackage(package2);
        shippingService.SendPackage(package3);

        Console.ReadKey(true);
    }
}