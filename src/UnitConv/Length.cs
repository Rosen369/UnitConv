using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv
{
    public class Length : ILength
    {
        public Length(decimal value, LengthUnit unit)
        {
            this.Value = value;
            this.Unit = unit;
        }

        public decimal Value { get; private set; }

        public LengthUnit Unit { get; private set; }

        internal Length ConvertValue(LengthUnit toUnit)
        {
            if (toUnit == this.Unit) return this;
            var basicRate = ConvertRateContainer.GetRate(this.Unit);
            var rate = ConvertRateContainer.GetRate(toUnit);
            var targetValue = Value * basicRate / rate;
            return new Length(targetValue, toUnit);
        }

        public ILength ToMile()
        {
            return this.ConvertValue(LengthUnit.Mile);
        }

        public ILength ToMeter()
        {
            return this.ConvertValue(LengthUnit.Meter);
        }

        public ILength ToKilometer()
        {
            return this.ConvertValue(LengthUnit.Kilometer);
        }

        public ILength ToCentimeter()
        {
            return this.ConvertValue(LengthUnit.Centimeter);
        }

        public ILength ToDecimeter()
        {
            return this.ConvertValue(LengthUnit.Decimeter);
        }

        public ILength ToMillimeter()
        {
            return this.ConvertValue(LengthUnit.Millimeter);
        }

        public ILength ToMicrometer()
        {
            return this.ConvertValue(LengthUnit.Micrometer);
        }

        public ILength ToNanometer()
        {
            return this.ConvertValue(LengthUnit.Nanometer);
        }

        public ILength ToPicometer()
        {
            return this.ConvertValue(LengthUnit.Picometer);
        }

        public ILength ToLightYear()
        {
            return this.ConvertValue(LengthUnit.LightYear);
        }

        public ILength ToAstronomicalUnit()
        {
            return this.ConvertValue(LengthUnit.AstronomicalUnit);
        }

        public ILength ToInch()
        {
            return this.ConvertValue(LengthUnit.Inch);
        }

        public ILength ToFoot()
        {
            return this.ConvertValue(LengthUnit.Foot);
        }

        public ILength ToYard()
        {
            return this.ConvertValue(LengthUnit.Yard);
        }

        public ILength ToFathom()
        {
            return this.ConvertValue(LengthUnit.Fathom);
        }

        public ILength ToFurlong()
        {
            return this.ConvertValue(LengthUnit.Furlong);
        }

        public ILength ToNauticalMile()
        {
            return this.ConvertValue(LengthUnit.NauticalMile);
        }

        public override string ToString()
        {
            return this.ToString(Languages.English, 3);
        }

        public string ToString(int digits)
        {
            return this.ToString(Languages.English, digits);
        }

        public string ToString(Languages language)
        {
            return this.ToString(language, 3);
        }

        public string ToString(Languages language, int digits)
        {
            var value = Math.Round(this.Value, digits).ToString();
            return value + UnitDisplayer.GetDisplay(language, this.Unit);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Length)) return false;
            return this.Equals(obj as Length);
        }

        public bool Equals(Length length)
        {
            var value = length.ConvertValue(this.Unit).Value;
            return value == this.Value;
        }

        public override int GetHashCode()
        {
            var hashCode = 1582882615;
            hashCode = hashCode * -1521134295 + Value.GetHashCode();
            hashCode = hashCode * -1521134295 + Unit.GetHashCode();
            return hashCode;
        }
    }
}
