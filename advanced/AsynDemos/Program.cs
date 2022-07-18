using System;
using System.Threading.Tasks;

namespace AsynDemos
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.ToString());

            var handler = new Asyncable();

            var result1 = handler.GetSum(1, 1);
            var result2 = handler.GetProduct(2, 2);

            await result1;
            await result2;

            Console.WriteLine(DateTime.Now.ToString());
            Console.WriteLine("Result1: " + result1.Result);
            Console.WriteLine("Result2: " + result2.Result);
            Console.ReadLine();
        }        
    }

    public class Asyncable
    {
        public async Task<int> GetSum(int a, int b)
        {
            await Task.Delay(3000);
            return a + b;
        }
        public async Task<int> GetProduct(int a, int b)
        {
            await Task.Delay(3000);
            return a * b;
        }
    }
}
