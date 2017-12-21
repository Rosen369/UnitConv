using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv
{
    public interface IUnitConverter
    {
        Length ConvertLength(decimal value, LengthUnit fromUnit, LengthUnit toUnit);

        Area ConvertLength(decimal value, AreaUnit fromUnit, AreaUnit toUnit);
    }
}
