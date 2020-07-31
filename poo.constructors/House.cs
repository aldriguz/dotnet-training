using System;

namespace poo.constructors {

    public class House {

        public decimal PriceDollars;
        public string Location;
        public int areaBuilded;

        public House(string location){ Location = location; }
        public House(string location, decimal priceDollars) : this (location) { PriceDollars = priceDollars; }
        
        // this is bad, cause line 12 method has signature of definition, so this method bellow invalid
        //public House(string locationLarge, decimal priceDollars) : this (locationLarge.Split(',').First(), priceDollars) { }

        public void InceptionMethod(decimal taxRate){

            //calculate peru tax
            decimal taxAmount = this.PriceDollars * taxRate;
            PrintValue(taxAmount);
            PrintLocationLength();

            void PrintValue(decimal taxCalculated) => Console.WriteLine(taxCalculated.ToString());
            void PrintLocationLength() => Console.WriteLine(this.Location!.Length);
        }
    }


}