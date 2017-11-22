using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv
{
    internal partial class ConvertRateContainer
    {
        private IDictionary<AreaUnit, decimal> _areaRateDic;

        private void InitAreaRate()
        {
            _areaRateDic = new Dictionary<AreaUnit, decimal>
            {
                { AreaUnit.SquareMeter, 1m },
                { AreaUnit.SquareDeciMeter, 0.01m },
                { AreaUnit.SquareCentimeter, 0.0001m },
                { AreaUnit.SquareMillimeter, 0.000001m },
                { AreaUnit.Are, 100m },
                { AreaUnit.Hectare, 10000m },
                { AreaUnit.SquareKilometer, 1000000m },
                { AreaUnit.Acre, 0.3048m*0.3048m*16.5m*16.5m*160m},
                { AreaUnit.SquareMile, 0.3048m*3m*1760m*0.3048m*3m*1760m },
                { AreaUnit.SquareYard, 0.3048m*0.3048m*9m },
                { AreaUnit.SquareFoot, 0.3048m*0.3048m },
                { AreaUnit.SquareInch, 0.3048m*0.3048m/144m },
            };
        }
    }
}
