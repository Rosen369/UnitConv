namespace UnitConv
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class EnDisplayer : LanguageDisplayer
    {
        protected override void InitLengthDisplay()
        {
            LengthDic = new Dictionary<LengthType, string>
            {
                { LengthType.Kilometer, "km" },
                { LengthType.Meter, "m" },
                { LengthType.Decimeter, "dm" },
                { LengthType.Centimeter, "cm" },
                { LengthType.Millimeter, "mm" },
                { LengthType.Micrometer, "um" },
                { LengthType.Nanometer, "nm" },
                { LengthType.Picometer, "pm" },
                { LengthType.LightYear, "ly" },
                { LengthType.AstronomicalUnit, "AU" },
                { LengthType.Mile, "mi" },
                { LengthType.Inch, "in" },
                { LengthType.Foot, "ft" },
                { LengthType.Yard, "yd" },
                { LengthType.Fathom, "fm" },
                { LengthType.Furlong, "fur" },
                { LengthType.NauticalMile, "nmi" },
            };
        }
    }
}
