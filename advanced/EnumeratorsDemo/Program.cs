using System.Collections.Generic;
using System.Linq;
using System;

namespace EnumeratorsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Better version: try with bigger numbers and see memory usage
            foreach (int i in GetOddNumbers(100))
            {
                Console.WriteLine($"Number {i}");
            }
            // The memory hungry beast
            //foreach (int i in EvenNumbers(1000000))
            //{
            //    Console.WriteLine($"Number: {i}");
            //}

            // Enumerating servers
            foreach (Server s in ServerDB())
            {
                Console.WriteLine($"Name: {s.Name}, Function: {s.Function}");
            }

            Console.ReadKey();
        }

        public static IEnumerable<int> GetOddNumbers(int max)
        {
            int i = 0;
            while (i < (max * 2))
            {
                yield return i;
                i += 2;
            }
        }
        public static List<int> EvenNumbers(int max)
        {
            var retList = new List<int>();
            int i = 0;
            while (retList.Count < max)
            {
                retList.Add(i += 2);
            }
            return retList;
        }

        public static IEnumerable<Server> ServerDB()
        {
            Server[] servers = new Server[]
                {
                new Server("Parabellum","Domain Controller"),
                new Server("Pluck","DNS Server"),
                new Server("Pilgrim","Web Server"),
                new Server("Spark","Firewall Server"),
                };
            foreach (Server s in servers)
            {
                yield return s;
            }
        }


    }

    public class Server
    {
        string _name;
        string _function;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Function
        {
            get { return _function; }
            set { _function = value; }
        }
        public Server(string Name, string Function)
        {
            _name = Name;
            _function = Function;
        }
    }
}
