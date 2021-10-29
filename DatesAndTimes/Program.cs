using System;
using System.Globalization;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Invalid dates
                DateTime.ParseExact("30112021", "MMddyyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            var yearFormatYY = DateTime.Now.Year%100;
            var customYearFormatYY = 2024 % 100;

            //utc
            var contractDate = new DateTimeOffset(2020, 10, 21, 13, 05, 20, TimeSpan.Zero);

            Console.WriteLine(contractDate);
            
            //extending 5 months
            //getting end date
            var expirationContractDate = contractDate.AddMonths(5).AddTicks(-1);

            Console.WriteLine(expirationContractDate);

        }
    }
}
