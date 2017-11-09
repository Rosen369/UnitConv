namespace UnitConv
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Length : Measurement
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
            if (toType == this.RawType) return this;
            var basicRate = ConvertRateContainer.GetRate(this.RawType);
            var rate = ConvertRateContainer.GetRate(toType);
            var targetValue = RawValue / basicRate * rate;
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

        public override string ToString(Languages language, int digits)
        {
            var value = Math.Round(this.RawValue, digits).ToString();
            return value + UnitDisplayer.GetDisplay(language, this.RawType);
        }
    }
}
