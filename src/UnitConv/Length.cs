using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv
{
    public class Length
    {
        public Length(decimal value, LengthUnit unit)
        {
            this.Value = value;
            this.Unit = unit;
        }

        public Length(string length)
        {
            var result = Util.ConvertQuantity<LengthUnit>(length);
            this.Value = result.Number;
            this.Unit = result.Unit;
        }

        public Length(string value, string unit)
        {
            this.Value = Util.ConvertValue(value);
            this.Unit = Util.ConvertUnit<LengthUnit>(unit);
        }

        public decimal Value { get; private set; }

        public LengthUnit Unit { get; private set; }

        internal Length ConvertValue(LengthUnit toUnit)
        {
            if (toUnit == this.Unit) return this;
            var basicRate = this.Unit.GetRate();
            var rate = toUnit.GetRate();
            var targetValue = Value * basicRate / rate;
            return new Length(targetValue, toUnit);
        }

        public Length ToMile()
        {
            return this.ConvertValue(LengthUnit.Mile);
        }

        public Length ToMeter()
        {
            return this.ConvertValue(LengthUnit.Meter);
        }

        public Length ToKilometer()
        {
            return this.ConvertValue(LengthUnit.Kilometer);
        }

        public Length ToCentimeter()
        {
            return this.ConvertValue(LengthUnit.Centimeter);
        }

        public Length ToDecimeter()
        {
            return this.ConvertValue(LengthUnit.Decimeter);
        }

        public Length ToMillimeter()
        {
            return this.ConvertValue(LengthUnit.Millimeter);
        }

        public Length ToMicrometer()
        {
            return this.ConvertValue(LengthUnit.Micrometer);
        }

        public Length ToNanometer()
        {
            return this.ConvertValue(LengthUnit.Nanometer);
        }

        public Length ToPicometer()
        {
            return this.ConvertValue(LengthUnit.Picometer);
        }

        public Length ToLightYear()
        {
            return this.ConvertValue(LengthUnit.LightYear);
        }

        public Length ToAstronomicalUnit()
        {
            return this.ConvertValue(LengthUnit.AstronomicalUnit);
        }

        public Length ToInch()
        {
            return this.ConvertValue(LengthUnit.Inch);
        }

        public Length ToFoot()
        {
            return this.ConvertValue(LengthUnit.Foot);
        }

        public Length ToYard()
        {
            return this.ConvertValue(LengthUnit.Yard);
        }

        public Length ToFathom()
        {
            return this.ConvertValue(LengthUnit.Fathom);
        }

        public Length ToFurlong()
        {
            return this.ConvertValue(LengthUnit.Furlong);
        }

        public Length ToNauticalMile()
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
            return value + this.Unit.GetDisplay(language);
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
