using System;
using System.Collections.Generic;
using System.Text;
using UnitConv.Units.LengthUnit;

namespace UnitConv
{
    public class UnitConverter : IUnitConverter
    {
        public ILength ConvertLength(decimal value, LengthUnit fromUnit, LengthUnit toUnit)
        {
            return new Length(value, fromUnit).ConvertValue(toUnit);
        }

        public IArea ConvertLength(decimal value, AreaUnit fromUnit, AreaUnit toUnit)
        {
            return new Area(value, fromUnit).ConvertValue(toUnit);
        }
    }
}
