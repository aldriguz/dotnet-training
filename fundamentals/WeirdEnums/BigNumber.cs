using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeirdEnums
{
    public class BigNumber
    {
        public static BigNumber One { get; } = new BigNumber(1, "One");
        public static BigNumber Ten { get; } = new BigNumber(10, "Ten");
        public static BigNumber OneHundred { get; } = new BigNumber(100, "One Hundred");
        public static BigNumber OneThousand { get; } = new BigNumber(1000, "One Thousand");
        public static BigNumber TenThousand { get; } = new BigNumber(10000, "Ten Thousand");
        public static BigNumber OneMillion { get; } = new BigNumber(100000, "One Million");
        public static BigNumber TenMillion { get; } = new BigNumber(1000000, "Ten Million");

        public string Name { get; private set; }
        public int Value { get; private set; }

        private BigNumber(int val, string name)
        {
            Value = val;
            Name = name;
        }

        public static IEnumerable<BigNumber> List()
        {
            // alternately, use a dictionary keyed by value
            return new[] { One, Ten, OneHundred, OneThousand, TenThousand, OneMillion, TenMillion };
        }

        public static BigNumber FromString(string BigNumberString)
        {
            return List().Single(r => String.Equals(r.Name, BigNumberString, StringComparison.OrdinalIgnoreCase));
        }

        public static BigNumber FromValue(int value)
        {
            return List().Single(r => r.Value == value);
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
