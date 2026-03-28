using System.Data;

namespace week8_task;

public class Letter : DeliveryItem
{
    public Letter(string trackingNumber, double weight) : base(trackingNumber, weight)
    {
        
    }

    public override double CalculateCost(double cost)
    {
        if (cost < 0)
        {
            throw new ArgumentException("cost cannot be negative");
        }

        return 15 + (Weight * 10);
        
    }
    
}