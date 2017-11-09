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

        public Length ToKilometer()
        {
            return this.ConvertValue(LengthType.Kilometer);
        }

        public Length ToCentimeter()
        {
            return this.ConvertValue(LengthType.Centimeter);
        }

        public Length ToDecimeter()
        {
            return this.ConvertValue(LengthType.Decimeter);
        }

        public Length ToMillimeter()
        {
            return this.ConvertValue(LengthType.Millimeter);
        }

        public Length ToMicrometer()
        {
            return this.ConvertValue(LengthType.Micrometer);
        }

        public Length ToNanometer()
        {
            return this.ConvertValue(LengthType.Nanometer);
        }

        public Length ToPicometer()
        {
            return this.ConvertValue(LengthType.Picometer);
        }

        public Length ToLightYear()
        {
            return this.ConvertValue(LengthType.LightYear);
        }

        public Length ToAstronomicalUnit()
        {
            return this.ConvertValue(LengthType.AstronomicalUnit);
        }

        public Length ToInch()
        {
            return this.ConvertValue(LengthType.Inch);
        }

        public Length ToFoot()
        {
            return this.ConvertValue(LengthType.Foot);
        }

        public Length ToYard()
        {
            return this.ConvertValue(LengthType.Yard);
        }

        public Length ToFathom()
        {
            return this.ConvertValue(LengthType.Fathom);
        }

        public Length ToFurlong()
        {
            return this.ConvertValue(LengthType.Furlong);
        }

        public Length ToNauticalMile()
        {
            return this.ConvertValue(LengthType.NauticalMile);
        }

        public override string ToString(Languages language, int digits)
        {
            var value = Math.Round(this.Value, digits).ToString();
            return value + UnitDisplayer.GetDisplay(language, this.LengthType);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Length)) return false;
            return this.Equals(obj as Length);
        }

        public bool Equals(Length length)
        {
            var value = length.ConvertValue(this.LengthType).Value;
            return value == this.Value;
        }
    }
}
