using System;
using System.Collections.Generic;
using System.Text;
using UnitConv.Units;

namespace UnitConv
{
    internal partial class ConvertRateContainer
    {
        private static ConvertRateContainer _instance = new ConvertRateContainer();

        private ConvertRateContainer()
        {
            this.InitLengthRate();
            this.InitAreaRate();
        }

        public static decimal GetRate(LengthUnit toUnit)
        {
            var value = 1m;
            var hasRate = _instance._lengthRateDic.TryGetValue(toUnit, out value);
            if (!hasRate) throw new Exception("convert not supported");
            return value;
        }

        public static decimal GetRate(AreaUnit toUnit)
        {
            var value = 1m;
            var hasRate = _instance._areaRateDic.TryGetValue(toUnit, out value);
            if (!hasRate) throw new Exception("convert not supported");
            return value;
        }
    }
}