using System;
using TryingGenerics.BasicDataStructure;

namespace TryingGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleStackDouble stack = new SimpleStackDouble(4);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
            Console.WriteLine("Program finished!");
        }
    }
}
