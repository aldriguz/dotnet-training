using System;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
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
