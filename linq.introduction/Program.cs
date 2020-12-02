using System;
using System.Collections.Generic;
using System.Linq;

namespace linq.introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IList<string> universities = new List<string>() {
                "Oxford - USA",
                "Standford - USA",
                "UNT - Perú",
                "UPN - Perú",
                "Universidad Alas Peruanas - Perú",
                "MIT - USA"
            };

            var nationalUniversities = from u in universities
                                        where u.Contains("Perú")
                                        select u;


            Console.WriteLine(string.Join(" | ", nationalUniversities));
        }


        
    }
}
