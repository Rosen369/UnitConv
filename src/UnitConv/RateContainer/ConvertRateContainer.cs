using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv
{
    internal partial class ConvertRateContainer
    {
        static ConvertRateContainer()
        {
            _instance = new ConvertRateContainer();
        }

        private static ConvertRateContainer _instance;

        private ConvertRateContainer()
        {
            this.InitLengthRate();
            this.InitAreaRate();
        }

        public static decimal GetRate(LengthUnit toUnit)
        {
            var value = 1m;
            var hasRate = _instance.LengthRateDic.TryGetValue(toUnit, out value);
            if (!hasRate) throw new Exception("convert not supported");
            return value;
        }

        public static decimal GetRate(AreaUnit toUnit)
        {
            var value = 1m;
            var hasRate = _instance.AreaRateDic.TryGetValue(toUnit, out value);
            if (!hasRate) throw new Exception("convert not supported");
            return value;
        }
    }
}