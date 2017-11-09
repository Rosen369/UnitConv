namespace UnitConv
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal partial class ConvertRateContainer
    {
        private IDictionary<LengthType, float> LengthRateDic { get; set; }

        private void InitLengthRate()
        {
            LengthRateDic = new Dictionary<LengthType, float>
            {
                { LengthType.Meter, 1f },
                { LengthType.Kilometer, 1000f },
                { LengthType.Decimeter, 0.1f },
                { LengthType.Centimeter, 0.01f },
                { LengthType.Millimeter, 0.001f },
                { LengthType.Micrometer, 0.000001f },
                { LengthType.Nanometer, 0.000000001f },
                { LengthType.Picometer, 0.000000000001f },
                { LengthType.LightYear, 9460730472580800f },
                { LengthType.AstronomicalUnit, 149597870700f },
                { LengthType.Foot, 0.304794f },
                { LengthType.Inch, 0.304794f / 12 },
                { LengthType.Yard, 0.304794f * 3 },
                { LengthType.Mile, 0.304794f * 3 * 1760 },
                { LengthType.Fathom, 1.8288f },
                { LengthType.Furlong, 201.168f },
                { LengthType.NauticalMile, 1852f }
            };
        }
    }
}
