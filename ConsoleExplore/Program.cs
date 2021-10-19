using System;

namespace ConsoleExplore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow; //background text color
            Console.ForegroundColor = ConsoleColor.Red; //text color
            Console.Title = "Personalizado";
            Console.WriteLine($"Tamaño de ventana: {Console.WindowHeight}x{Console.WindowWidth}");
            string input = "";

            do
            {
                Console.Write("Escribe (q) o (Q) para salir:");
                input = Console.ReadLine();
            } while (input != "q" && input != "Q");
        }
    }
}
