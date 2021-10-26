using System;
using System.Collections.Generic;

namespace GarbageCollector
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MemoryKiller> lstMemory = new List<MemoryKiller>();
            
            //Double amount = 1 000 000M;
            
            for (int i = 0; i < 100000000; i++)
            {
                lstMemory.Add(new MemoryKiller(1, DateTime.Now, 100));
            }

            lstMemory.Clear();
            lstMemory = null;

            GC.Collect(); //this line runs garbage collector to free memory
            
            Console.WriteLine("Press key to quit...");
            Console.ReadLine();
        }
    }
}
