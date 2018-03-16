using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Converter
{
    public class SpeedConverter : ConverterBase<Speed, SpeedUnit>
    {
        private SpeedConverter()
        {

        }

        private static SpeedConverter _instance = new SpeedConverter();

        public static SpeedConverter GetInstance()
        {
            return _instance;
        }
    }
}
