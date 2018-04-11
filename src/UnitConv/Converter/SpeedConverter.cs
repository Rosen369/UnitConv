using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Converter
{
    public class SpeedConverter : ConverterBase<Speed, SpeedUnit>
    {
        private class Nested
        {
            internal static readonly SpeedConverter Instance = new SpeedConverter();
        }

        private SpeedConverter()
        {

        }

        public static SpeedConverter GetInstance()
        {
            return Nested.Instance;
        }
    }
}
