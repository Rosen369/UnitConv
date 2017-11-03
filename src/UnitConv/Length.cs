namespace UnitConv
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Length
    {
        public Length(float value, LengthType type)
        {
            this.RawValue = value;
            this.RawType = type;
        }

        private float RawValue { get; set; }

        private LengthType RawType { get; set; }

        internal Length ConvertValue(LengthType toType)
        {
            if (toType == RawType) return this;
            var rate = ConvertRateContainer.GetRate(this.RawType, toType);
            var targetValue = RawValue * rate;
            return new Length(targetValue, toType);
        }

        public Length ToMile()
        {
            return this.ConvertValue(LengthType.Mile);
        }

        public Length ToMeter()
        {
            return this.ConvertValue(LengthType.Meter);
        }
    }
}
