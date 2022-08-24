using System;
using Creational.FactoryMethod;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {            
            FactoryFlow();
        }

        private static void FactoryFlow(){
            Application app = new Application();
            app.Main("Desktop"); //will handle Window button
            app.Main("Web"); //will handle Window button
        }
    }
}
