public class TeslaModelS : ICar
{
    // explicit implementation, this implementation belongs to the interface
    bool ICar.StartEngine()
    {
        Console.WriteLine("Checking engine... (Explicit implementation)");
        Console.WriteLine("Electric engine started.");
        return true;
    }

    bool ICar.StopEngine()
    {
        Console.WriteLine("Checking if engine is ON..(Explicit implementation).");
        Console.WriteLine("Electric engine stopped.");
        return true;
    }
}