namespace week8_task;

class Program
{
    static void Main()
    {
        
        Letter letter1 = new Letter("L067", 0.3);
        Letter letter2 = new Letter("L076", 0.8);

        Parcel parcel1 = new Parcel("P053", 2.5, "50x60x67");
        Parcel parcel2 = new Parcel("P099", 5.0, "50x30x90");
        
        
        Console.WriteLine("Print Info:");
        letter1.PrintInfo();
        parcel1.PrintInfo();

        
        CargoContainer<DeliveryItem> myCargo = new CargoContainer<DeliveryItem>();

        myCargo.AddItem(letter1);
        myCargo.AddItem(letter2);
        myCargo.AddItem(parcel1);
        myCargo.AddItem(parcel2);

        
        Console.WriteLine("\nTotal Cost:");
        Console.WriteLine($"Total delivery cost: {myCargo.GetTotalCost()} грн");
    }
    
}