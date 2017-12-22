using System;
using System.Collections.Generic;
using System.Text;
using UnitConv.Units;

namespace UnitConv.Converter
{
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
    }
}
