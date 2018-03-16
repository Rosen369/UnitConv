using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using UnitConv.Units;

namespace UnitConv
{
    /// <summary>
    /// helper class handle string input
    /// </summary>
    public static class Util
    {
        /// <summary>
        /// convert a string value into decimal
        /// </summary>
        /// <param name="value">value in string</param>
        /// <returns></returns>
        public static decimal ConvertValue(string value)
        {
            return Convert.ToDecimal(value);
        }

        /// <summary>
        /// convert a string unit into unit type
        /// </summary>
        /// <typeparam name="T">type of unit to convert</typeparam>
        /// <param name="unit">string value of unit type</param>
        /// <returns></returns>
        public static T ConvertUnit<T>(string unit) where T : Unit
        {
            var dic = UnitContainer.UnitDic;
            if (!dic.ContainsKey(unit)) throw new Exception("Invalid unit type!");
            var result = dic[unit];
            return result as T;
        }

        /// <summary>
        /// split a quantity value into number string and unit string
        /// </summary>
        /// <param name="quantity">string quantity value</param>
        /// <returns></returns>
        public static (string Number, string Unit) SplitQuantity(string quantity)
        {
            var number = Regex.Match(quantity, @"^\d+\.?\d*").Value;
            if (string.IsNullOrEmpty(number)) throw new Exception("Invalid quantity!");
            var unit = quantity.Replace(number, string.Empty);
            if (string.IsNullOrEmpty(unit)) throw new Exception("Invalid quantity!");
            return (number, unit);
        }

        /// <summary>
        /// split a quantity value into decicmal and unit
        /// </summary>
        /// <typeparam name="T">type of unit to convert</typeparam>
        /// <param name="quantity">string quantity value</param>
        /// <returns></returns>
        public static (decimal Number, T Unit) ConvertQuantity<T>(string quantity) where T : Unit
        {
            var splitResult = SplitQuantity(quantity);
            var number = ConvertValue(splitResult.Number);
            var unit = ConvertUnit<T>(splitResult.Unit);
            return (number, unit);
        }
    }
}
