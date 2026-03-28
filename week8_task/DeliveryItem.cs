namespace week8_task;

public abstract class DeliveryItem
{
    public string TrackingNumber { get; private set; }
    public double Weight { get; private set; }
    

    public DeliveryItem(string trackingNumber, double weight)
    {
        TrackingNumber = trackingNumber;
        Weight = weight;

    }

    public abstract double CalculateCost();

    public virtual void PrintInfo()
    {
        Console.WriteLine($"your track number is {TrackingNumber}, weight is {Weight}");
        
    }

}