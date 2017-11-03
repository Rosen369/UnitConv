namespace UnitConv
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class UnitConverter : IUnitConverter
    {
        public Length ConvertLength(float value, LengthType fromType, LengthType toType)
        {
            var rawLength = new Length(value, fromType);
            switch (toType)
            {
                case LengthType.Meter:
                    return rawLength.ToMeter();
                case LengthType.Mile:
                    return rawLength.ToMile();
                default:
                    throw new Exception("not supported convert");
            }
        }
    }
}
