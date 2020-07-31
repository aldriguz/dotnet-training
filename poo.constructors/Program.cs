using System;

namespace poo.constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House("Psj Ramon Castilla - Trujillo - Peru", 150_000);

            house.InceptionMethod(0.16);
        }
    }
}
