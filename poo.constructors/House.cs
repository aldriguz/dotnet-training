using System;
using poo.constructors.Preprocesor;

namespace poo.constructors {

    public class House {

        //members
        public decimal PriceDollars;
        public string Location;
        public int areaBuilded;
        private string priceText;

        //properties
        public string PriceText
        {
            get { return priceText; }
            set
            {
                if(value.IsValidType(DataType.LocalDecimal))
                    priceText = value;
                else
                {
                    priceText = "INVALID";
                }
            }
        }

        public House(string location){ Location = location; }
        public House(string location, decimal priceDollars) : this (location) { PriceDollars = priceDollars; }
        
        // this is bad, cause line 12 method has signature of definition, so this method bellow invalid
        //public House(string locationLarge, decimal priceDollars) : this (locationLarge.Split(',').First(), priceDollars) { }

        public void InceptionMethod(decimal taxRate){

            //calculate peru tax
            decimal taxAmount = this.PriceDollars * taxRate;
            this.PriceText = taxRate.ToString();

            PrintValue(taxAmount);
            PrintLocationLength();
            PrintTextPrice();

            void PrintValue(decimal taxCalculated) => Console.WriteLine(taxCalculated.ToString());
            void PrintLocationLength() => Console.WriteLine(this.Location!.Length);
            void PrintTextPrice() => Console.WriteLine(this.PriceText);
        }
    }


}