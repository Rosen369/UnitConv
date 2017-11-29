using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv
{
    public interface IUnitConverter
    {
        ILength ConvertLength(decimal value, LengthUnit fromUnit, LengthUnit toUnit);

        IArea ConvertLength(decimal value, AreaUnit fromUnit, AreaUnit toUnit);
    }
}
