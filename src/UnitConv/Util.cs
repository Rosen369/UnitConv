using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using UnitConv.Units;

namespace UnitConv
{
    public static class Util
    {
        public static ValueTuple<string, string> SplitQuantity(string quantity)
        {
            var number = Regex.Match(quantity, @"^\d+\.?\d*").Value;
            if (string.IsNullOrEmpty(number)) throw new Exception("Invalid quantity!");
            var unit = quantity.Replace(number, string.Empty);
            if (string.IsNullOrEmpty(unit)) throw new Exception("Invalid quantity!");
            return (number, unit);
        }

        public static decimal ConvertValue(string value)
        {
            return Convert.ToDecimal(value);
        }

        public static Unit ConvertUnit(string unit)
        {
            return LengthUnit.Meter;
        }
    }
}
