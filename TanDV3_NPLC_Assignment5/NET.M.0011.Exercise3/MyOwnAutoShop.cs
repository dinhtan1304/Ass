using NET.M._0011.Exercise3;

internal class MyOwnAutoShop
{
    private static void Main(string[] args)
    {
        Console.WriteLine("All Car with RegualPrice = 10000");

        Truck truck = new Truck()
        {
            Speed = 1,
            RegualPrice = 10000,
            Color = "red",
            Weight = 3000
        };
        Console.Write("Get Sale Price Of Truck With Weight > 2000: ");
        Console.WriteLine(truck.GetSalePrice());

        Truck truck1 = new Truck()
        {
            Speed = 1,
            RegualPrice = 10000,
            Color = "red",
            Weight = 1000
        };
        Console.Write("Get Sale Price Of Truck With Weight < 2000: ");
        Console.WriteLine(truck1.GetSalePrice());

        Ford ford = new Ford()
        {
            Speed = 1,
            RegualPrice = 10000,
            Color = "red",
            Year = 2020,
            ManufactureDiscount = 2000
        };
        Console.Write("Get Sale Price Of Ford With ManufacturerDiscount = 2000: ");
        Console.WriteLine(ford.GetSalePrice());

        Sedan sedan = new Sedan()
        {
            Speed = 1,
            RegualPrice = 10000,
            Color = "red",
            Lenght = 30
        };
        Console.Write("Get Sale Price Of Sedan With Lenght = 30: ");
        Console.WriteLine(sedan.GetSalePrice());

        Sedan sedan1 = new Sedan()
        {
            Speed = 1,
            RegualPrice = 10000,
            Color = "red",
            Lenght = 15
        };
        Console.Write("Get Sale Price Of Sedan With Lenght = 15: ");
        Console.WriteLine(sedan1.GetSalePrice());

    }
}