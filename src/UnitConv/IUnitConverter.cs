using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv
{
    public interface IUnitConverter
    {
        Length ConvertLength(float value, LengthUnit fromUnit, LengthUnit toUnit);
    }
}
