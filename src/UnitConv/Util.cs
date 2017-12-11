﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using UnitConv.Units;

namespace UnitConv
{
    public static class Util
    {
        public static decimal ConvertValue(string value)
        {
            return Convert.ToDecimal(value);
        }

        public static T ConvertUnit<T>(string unit) where T : Unit
        {
            //var typeDic =;
            var result = LengthUnit.Meter;
            return result as T;
        }

        public static (string Number, string Unit) SplitQuantity(string quantity)
        {
            var number = Regex.Match(quantity, @"^\d+\.?\d*").Value;
            if (string.IsNullOrEmpty(number)) throw new Exception("Invalid quantity!");
            var unit = quantity.Replace(number, string.Empty);
            if (string.IsNullOrEmpty(unit)) throw new Exception("Invalid quantity!");
            return (number, unit);
        }

        public static (decimal Number, T Unit) ConvertQuantity<T>(string quantity) where T : Unit
        {
            var splitResult = SplitQuantity(quantity);
            var number = ConvertValue(splitResult.Number);
            var unit = ConvertUnit<T>(splitResult.Unit);
            return (number, unit);
        }
    }
}
