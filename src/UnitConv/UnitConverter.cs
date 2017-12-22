using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv
{
    public class UnitConverter : IUnitConverter
    {
        public Area ConvertArea(decimal value, AreaUnit fromUnit, AreaUnit toUnit)
        {
            return new Area(value, fromUnit).ConvertValue(toUnit);
        }

        public Area ConvertArea(decimal value, string fromUnit, string toUnit)
        {
            var unit = Util.ConvertUnit<AreaUnit>(toUnit);
            return new Area(value, fromUnit).ConvertValue(unit);
        }

        public Area ConvertArea(string area, string toUnit)
        {
            var unit = Util.ConvertUnit<AreaUnit>(toUnit);
            return new Area(area).ConvertValue(unit);
        }

        public Area ConvertArea(string area, AreaUnit toUnit)
        {
            return new Area(area).ConvertValue(toUnit);
        }

        public Length ConvertLength(decimal value, LengthUnit fromUnit, LengthUnit toUnit)
        {
            return new Length(value, fromUnit).ConvertValue(toUnit);
        }

        public Length ConvertLength(decimal value, string fromUnit, string toUnit)
        {
            var unit = Util.ConvertUnit<LengthUnit>(toUnit);
            return new Length(value, fromUnit).ConvertValue(unit);
        }

        public Length ConvertLength(string length, LengthUnit toUnit)
        {
            return new Length(length).ConvertValue(toUnit);
        }

        public Length ConvertLength(string length, string toUnit)
        {
            var unit = Util.ConvertUnit<LengthUnit>(toUnit);
            return new Length(length).ConvertValue(unit);
        }
    }
}

