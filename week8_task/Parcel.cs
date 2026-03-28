namespace week8_task;

public class Parcel : DeliveryItem
{
    public string Dimensions { get; private set; }

    public Parcel(string trackingNumber, double weight, string dimensions)
        : base(trackingNumber, weight)
    {
        Dimensions = dimensions;
        
    }

    public override double CalculateCost(double cost)
    {
        if (cost < 0)
        {
            throw new ArgumentException("cost cannot be negative");
        }

        return 50 + (Weight * 25);

    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Dimensions: {Dimensions}");

    }
    
}
