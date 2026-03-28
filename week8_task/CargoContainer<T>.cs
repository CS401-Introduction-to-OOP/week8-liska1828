namespace week8_task;

public class CargoContainer <T> where T : DeliveryItem
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
        
    }

    public double GetTotalCost()
    {
        double total = 0;
        
        foreach (var item in items)
        {
            total += item.CalculateCost();
            
        }

        return total;

    }
  
}