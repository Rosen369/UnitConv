using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv
{
    internal partial class ConvertRateContainer
    {
        private IDictionary<LengthUnit, float> LengthRateDic { get; set; }

        private void InitLengthRate()
        {
            LengthRateDic = new Dictionary<LengthUnit, float>
            {
                { LengthUnit.Meter, 1f },
                { LengthUnit.Kilometer, 1000f },
                { LengthUnit.Decimeter, 0.1f },
                { LengthUnit.Centimeter, 0.01f },
                { LengthUnit.Millimeter, 0.001f },
                { LengthUnit.Micrometer, 0.000001f },
                { LengthUnit.Nanometer, 0.000000001f },
                { LengthUnit.Picometer, 0.000000000001f },
                { LengthUnit.LightYear, 9460730472580800f },
                { LengthUnit.AstronomicalUnit, 149597870700f },
                { LengthUnit.Foot, 0.304794f },
                { LengthUnit.Inch, 0.304794f / 12 },
                { LengthUnit.Yard, 0.304794f * 3 },
                { LengthUnit.Mile, 0.304794f * 3 * 1760 },
                { LengthUnit.Fathom, 1.8288f },
                { LengthUnit.Furlong, 201.168f },
                { LengthUnit.NauticalMile, 1852f }
            };
        }
    }
}
