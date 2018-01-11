using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv
{
    public static class LengthExtension
    {
        public static Length ToMile(this Length length)
        {
            return length.ConvertValue(LengthUnit.Mile);
        }

        public static Length ToMeter(this Length length)
        {
            return length.ConvertValue(LengthUnit.Meter);
        }

        public static Length ToKilometer(this Length length)
        {
            return length.ConvertValue(LengthUnit.Kilometer);
        }

        public static Length ToCentimeter(this Length length)
        {
            return length.ConvertValue(LengthUnit.Centimeter);
        }

        public static Length ToDecimeter(this Length length)
        {
            return length.ConvertValue(LengthUnit.Decimeter);
        }

        public static Length ToMillimeter(this Length length)
        {
            return length.ConvertValue(LengthUnit.Millimeter);
        }

        public static Length ToMicrometer(this Length length)
        {
            return length.ConvertValue(LengthUnit.Micrometer);
        }

        public static Length ToNanometer(this Length length)
        {
            return length.ConvertValue(LengthUnit.Nanometer);
        }

        public static Length ToPicometer(this Length length)
        {
            return length.ConvertValue(LengthUnit.Picometer);
        }

        public static Length ToLightYear(this Length length)
        {
            return length.ConvertValue(LengthUnit.LightYear);
        }

        public static Length ToAstronomicalUnit(this Length length)
        {
            return length.ConvertValue(LengthUnit.AstronomicalUnit);
        }

        public static Length ToInch(this Length length)
        {
            return length.ConvertValue(LengthUnit.Inch);
        }

        public static Length ToFoot(this Length length)
        {
            return length.ConvertValue(LengthUnit.Foot);
        }

        public static Length ToYard(this Length length)
        {
            return length.ConvertValue(LengthUnit.Yard);
        }

        public static Length ToFathom(this Length length)
        {
            return length.ConvertValue(LengthUnit.Fathom);
        }

        public static Length ToFurlong(this Length length)
        {
            return length.ConvertValue(LengthUnit.Furlong);
        }

        public static Length ToNauticalMile(this Length length)
        {
            return length.ConvertValue(LengthUnit.NauticalMile);
        }
    }
}

