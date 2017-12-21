using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv
{
    public class UnitConverter : IUnitConverter
    {
        public Length ConvertLength(decimal value, LengthUnit fromUnit, LengthUnit toUnit)
        {
            return new Length(value, fromUnit).ConvertValue(toUnit);
        }

        public Area ConvertLength(decimal value, AreaUnit fromUnit, AreaUnit toUnit)
        {
            return new Area(value, fromUnit).ConvertValue(toUnit);
        }
    }
}
