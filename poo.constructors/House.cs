using System;

namespace poo.constructors {

    public class House {

        public decimal PriceDollars;
        public string Location;
        public int areaBuilded;

        public House(string location){ Location = location; }
        public House(string location, decimal priceDollars) : this (priceDollars) { Location = location; }
        public House(string locationLarge, decimal priceDollars) : this (locationLarge.Split(',').First(), priceDollars) { }

        public void InceptionMethod(decimal taxRate){

            //calculate peru tax
            decimal taxAmount = this.PriceDollars * taxRate;


            void PrintValue(decimal amountDisplay) => Console.WriteLine(amountDisplay);
        }
    }


}