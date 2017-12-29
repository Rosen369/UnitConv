using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv
{
    /// <summary>
    /// quantity type of length
    /// </summary>
    public class Length : Quantity<LengthUnit, Length>
    {
        public Length(decimal value, LengthUnit unit) : base(value, unit)
        {

        }

        public Length(string length) : base(length)
        {

        }

        public Length(string value, string unit) : base(value, unit)
        {

        }

        public Length(decimal value, string unit) : base(value, unit)
        {

        }

        public Length(string value, LengthUnit unit) : base(value, unit)
        {

        }

        protected internal override Length ConvertValue(LengthUnit toUnit)
        {
            if (toUnit == this.Unit) new Length(this.Value, toUnit);
            var basicRate = this.Unit.GetRate();
            var rate = toUnit.GetRate();
            var targetValue = this.Value * basicRate / rate;
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
    }
}
