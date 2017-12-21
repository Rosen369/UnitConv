using System;
using System.Collections.Generic;
using System.Text;
using UnitConv.Units;

namespace UnitConv
{
    internal class EnDisplayer : LanguageDisplayer
    {
        protected override void InitAreaDisplay()
        {
            AreaDic = new Dictionary<AreaUnit, string>
            {
               { AreaUnit.SquareMeter,"m²"},
               { AreaUnit.SquareDeciMeter,"dm²"},
               { AreaUnit.SquareCentimeter,"cm²"},
               { AreaUnit.SquareMillimeter,"mm²"},
               { AreaUnit.Are,"are"},
               { AreaUnit.SquareKilometer,"km²"},
               { AreaUnit.Hectare,"ha"},
               { AreaUnit.Acre,"acre"},
               { AreaUnit.SquareMile,"sq.mi"},
               { AreaUnit.SquareYard,"sq.yd"},
               { AreaUnit.SquareFoot,"sq.ft"},
               { AreaUnit.SquareInch,"sq.in"}
            };
        }

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
