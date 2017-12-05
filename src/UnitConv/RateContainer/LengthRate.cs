using System;
using System.Collections.Generic;
using System.Text;
using UnitConv.Units.LengthUnit;

namespace UnitConv
{
    internal partial class ConvertRateContainer
    {
        private IDictionary<LengthUnit, decimal> _lengthRateDic;

        private void InitLengthRate()
        {
            _lengthRateDic = new Dictionary<LengthUnit, decimal>
            {
                { LengthUnit.Meter, 1m },
                { LengthUnit.Kilometer, 1000m },
                { LengthUnit.Decimeter, 0.1m },
                { LengthUnit.Centimeter, 0.01m },
                { LengthUnit.Millimeter, 0.001m },
                { LengthUnit.Micrometer, 0.000001m },
                { LengthUnit.Nanometer, 0.000000001m },
                { LengthUnit.Picometer, 0.000000000001m },
                { LengthUnit.LightYear, 9460730472580800m },
                { LengthUnit.AstronomicalUnit, 149597870700m },
                { LengthUnit.Foot, 0.304794m },
                { LengthUnit.Inch, 0.304794m / 12m },
                { LengthUnit.Yard, 0.304794m * 3m },
                { LengthUnit.Mile, 0.304794m * 3m * 1760m },
                { LengthUnit.Fathom, 1.8288m },
                { LengthUnit.Furlong, 201.168m },
                { LengthUnit.NauticalMile, 1852m }
            };
        }
    }
}
