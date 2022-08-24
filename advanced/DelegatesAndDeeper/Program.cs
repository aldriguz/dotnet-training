using System;
using static DelegatesAndDeeper.MineOfDelegates;

namespace DelegatesAndDeeper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintCmd display = printInConsole;
            display.Invoke("message for delegate call using Invoke!");
            display("message for delegate call implicit inkove.");
        }

        public static void printInConsole(string customMessage)
        {
            Console.WriteLine("Running message from delegate saying this: " + customMessage);
        }
    }
}
