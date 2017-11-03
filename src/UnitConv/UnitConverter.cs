namespace UnitConv
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class UnitConverter : IUnitConverter
    {
        public Length ConvertLength(float value, LengthType fromType, LengthType toType)
        {
            return new Length(value, fromType).ConvertValue(toType);
        }
    }
}
