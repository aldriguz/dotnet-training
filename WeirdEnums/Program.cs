using System;

namespace WeirdEnums
{
    /// <summary>
    /// Taken from example SmartEnum of Ardalis
    /// https://ardalis.com/enum-alternatives-in-c/?utm_sq=gm3c9bwfku
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio de programa");

            Console.WriteLine("Extension: {0}", EnumBigNumber.OneMillion.GetFullName());
            Console.WriteLine("ToString: {0}", DoSomething((EnumBigNumber)1));
            Console.WriteLine("Class ToString: {0}", BigNumber.FromValue(100000));
        }

        public static string DoSomething(EnumBigNumber bigNumber)
        {
            return bigNumber.ToString();
        }
    }
}
