using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using UnitConv.Units;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("UnitTest, PublicKey=0024000004800000940000000602000000240000525341310004000001000100e5c0e429c20f23251e2bc6a11e8c4bfb003f536314422c15069bfd7974da34fb128a1a3e1247ade1e7ffc4efb4b80dd8b4a17f6dbac677dd995df69a460cd35a04742b1e0deae6e9c4dce12d772bf3617c2e0e410736537f0070116ed2dbd9be99d8d8802b77023e044e31b03cc880b66663a37d583610baea87cb9b7cbaa8ce")]
namespace UnitConv.Utils
{
    /// <summary>
    /// helper class handle string input
    /// </summary>
    internal static class Util
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
            var concrete = UnitContainer.TryGetUnit<T>(unit);
            if (concrete == null) throw new Exception("Invalid unit type!");
            return concrete;
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
