namespace UnitConv
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class EnDisplayer : LanguageDisplayer
    {
        protected override void InitLengthDisplay()
        {
            LengthDic = new Dictionary<LengthUnit, string>
            {
                { LengthUnit.Kilometer, "km" },
                { LengthUnit.Meter, "m" },
                { LengthUnit.Decimeter, "dm" },
                { LengthUnit.Centimeter, "cm" },
                { LengthUnit.Millimeter, "mm" },
                { LengthUnit.Micrometer, "um" },
                { LengthUnit.Nanometer, "nm" },
                { LengthUnit.Picometer, "pm" },
                { LengthUnit.LightYear, "ly" },
                { LengthUnit.AstronomicalUnit, "AU" },
                { LengthUnit.Mile, "mi" },
                { LengthUnit.Inch, "in" },
                { LengthUnit.Foot, "ft" },
                { LengthUnit.Yard, "yd" },
                { LengthUnit.Fathom, "fm" },
                { LengthUnit.Furlong, "fur" },
                { LengthUnit.NauticalMile, "nmi" },
            };
        }
    }
}
