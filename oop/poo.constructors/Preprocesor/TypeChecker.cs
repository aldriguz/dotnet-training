using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace poo.constructors.Preprocesor
{
    public static class TypeChecker
    {

        public static bool IsValidType(this string value, DataType dataType)
        {
            bool isValid = false;

            switch (dataType)
            {
                case DataType.LocalDecimal:
                    decimal decimalValue = 0;
                    if(Decimal.TryParse(value, out decimalValue))
                    {
                        isValid = true;
                    }
                    break;
            }

            return isValid;
        }
    }

    public enum DataType
    {
        LocalDecimal
    }
}
