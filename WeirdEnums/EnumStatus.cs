using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeirdEnums
{
    public enum EnumBigNumber
    {
        One             = 1,
        Ten             = 10,
        OneHundred      = 100,
        OneThousand     = 1000,
        TenThousand     = 10000,
        OneMillion      = 100000,
        TenMillion      = 1000000
    }

    public static class BigNumberExtension
    {
        public static string GetFullName(this EnumBigNumber enumBigNumber)
        {
            Enum.GetName(enumBigNumber);
            return enumBigNumber.ToString();            
        }
    }
}
