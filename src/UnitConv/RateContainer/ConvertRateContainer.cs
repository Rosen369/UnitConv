namespace UnitConv
{
    using System;
    using System.Collections.Generic;
    using System.Text;

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
        }

        public static float GetRate(LengthType fromType, LengthType toType)
        {
            var value = 1f;
            var hasRate = _instance.LengthRateDic.TryGetValue((fromType, toType), out value);
            if (!hasRate) throw new Exception("convert not supported");
            return value;
        }
    }
}