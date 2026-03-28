using System.Data;

namespace week8_task;

public class Letter : DeliveryItem
{
    public Letter(string trackingNumber, double weight) : base(trackingNumber, weight)
    {
        
    }

    public override double CalculateCost()
    {
        return 15 + (Weight * 10);
        
    }
    
}