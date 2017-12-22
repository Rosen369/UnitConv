using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv
{
    public interface IUnitConverter
    {
        Length ConvertLength(decimal value, LengthUnit fromUnit, LengthUnit toUnit);

        Length ConvertLength(decimal value, string fromUnit, string toUnit);

        Length ConvertLength(string length, LengthUnit toUnit);

        Length ConvertLength(string length, string toUnit);

        Area ConvertArea(decimal value, AreaUnit fromUnit, AreaUnit toUnit);

        Area ConvertArea(decimal value, string fromUnit, string toUnit);

        Area ConvertArea(string area, AreaUnit toUnit);

        Area ConvertArea(string area, string toUnit);
    }
}
