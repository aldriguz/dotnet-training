public class ToyotaCorolla : ICar
{
    public bool StartEngine()
    {
        Console.WriteLine("Electric engine started.");
        return true;
    }

    public bool StopEngine()
    {
        Console.WriteLine("Electric engine stopped.");
        return true;
    }
}