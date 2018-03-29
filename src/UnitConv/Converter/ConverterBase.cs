using System;
using System.Collections.Generic;
using System.Text;
using UnitConv.Units;
using UnitConv.Utils;

namespace UnitConv.Converter
{
    /// <summary>
    /// unit converter base
    /// </summary>
    /// <typeparam name="TQuantity">quantity type to convert</typeparam>
    /// <typeparam name="TUnit">quantity unit type</typeparam>
    public abstract class ConverterBase<TQuantity, TUnit> where TQuantity : Quantity<TUnit, TQuantity> where TUnit : Unit
    {
        public TQuantity Convert(decimal value, TUnit fromUnit, TUnit toUnit)
        {
            var item = Activator.CreateInstance(typeof(TQuantity), value, fromUnit) as TQuantity;
            return item.ConvertValue(toUnit);
        }

        public TQuantity Convert(decimal value, string fromUnit, string toUnit)
        {
            var unit = Util.ConvertUnit<TUnit>(toUnit);
            var item = Activator.CreateInstance(typeof(TQuantity), value, fromUnit) as TQuantity;
            return item.ConvertValue(unit);
        }

        public TQuantity Convert(string quantity, string toUnit)
        {
            var unit = Util.ConvertUnit<TUnit>(toUnit);
            var item = Activator.CreateInstance(typeof(TQuantity), quantity) as TQuantity;
            return item.ConvertValue(unit);
        }

        public TQuantity Convert(string quantity, TUnit toUnit)
        {
            var item = Activator.CreateInstance(typeof(TQuantity), quantity) as TQuantity;
            return item.ConvertValue(toUnit);
        }

        public TQuantity Convert(TQuantity quantity, TUnit toUnit)
        {
            return quantity.ConvertValue(toUnit);
        }

        public TQuantity Convert(TQuantity quantity, string toUnit)
        {
            var unit = Util.ConvertUnit<TUnit>(toUnit);
            return quantity.ConvertValue(unit);
        }
    }
}
