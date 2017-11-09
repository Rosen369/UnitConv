namespace UnitConv
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Length : Measurement
    {
        public Length(float value, LengthType type)
        {
            this.Value = value;
            this.LengthType = type;
        }

        public float Value { get; private set; }

        public LengthType LengthType { get; private set; }

        internal Length ConvertValue(LengthType toType)
        {
            if (toType == this.LengthType) return this;
            var basicRate = ConvertRateContainer.GetRate(this.LengthType);
            var rate = ConvertRateContainer.GetRate(toType);
            var targetValue = Value * basicRate / rate;
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
            var value = Math.Round(this.Value, digits).ToString();
            return value + UnitDisplayer.GetDisplay(language, this.LengthType);
        }
    }
}
