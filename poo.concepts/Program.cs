using System;

namespace poo.concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock msft = new Stock {
                Name = "MSFT",
                SharesOwned = 1_000_000
            };

            Console.WriteLine(msft.Name);
            Console.WriteLine(msft.SharesOwned);

            House flat = new House{
                Name = "Flat 1 floor",
                Mortgage = 85_000
            };

            Console.WriteLine(flat.Name);
            Console.WriteLine(flat.Mortgage);

        }
    }
}
