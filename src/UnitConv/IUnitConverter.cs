namespace UnitConv
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IUnitConverter
    {
        Length ConvertLength(float value, LengthType fromType, LengthType toType);
    }
}
