using System;

namespace poo.constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal totalPrice = 45000M, taxRate = 0.16M;
            
            string location = "Psj Ramon Castilla - Trujillo - Peru";

            House house = new House(location, totalPrice);

            house.InceptionMethod(taxRate);
        }
    }
}
