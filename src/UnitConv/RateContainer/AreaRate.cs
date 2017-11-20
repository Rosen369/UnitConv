using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv
{
    internal partial class ConvertRateContainer
    {
        private IDictionary<AreaUnit, float> AreaRateDic { get; set; }

        private void InitAreaRate()
        {
            AreaRateDic = new Dictionary<AreaUnit, float>
            {
                { AreaUnit.SquareMeter, 1f },
                { AreaUnit.SquareDeciMeter, 0.01f },
                { AreaUnit.SquareCentimeter, 0.0001f },
                { AreaUnit.SquareMillimeter, 0.000001f },
                { AreaUnit.Are, 100f },
                { AreaUnit.Hectare, 10000f },
                { AreaUnit.SquareKilometer, 1000000f },
                { AreaUnit.Acre, 0.3048f*0.3048f*16.5f*16.5f*160f},
                { AreaUnit.SquareMile, 0.3048f*3f*1760f*0.3048f*3f*1760f },
                { AreaUnit.SquareYard, 0.3048f*0.3048f*9 },
                { AreaUnit.SquareFoot, 0.3048f*0.3048f },
                { AreaUnit.SquareInch, 0.3048f*0.3048f/144 },
            };
        }
    }
}
