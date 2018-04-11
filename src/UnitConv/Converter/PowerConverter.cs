using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Converter
{
    public class PowerConverter : ConverterBase<Power, PowerUnit>
    {
        private class Nested
        {
            internal static readonly PowerConverter Instance = new PowerConverter();
        }

        private PowerConverter()
        {

        }

        public static PowerConverter GetInstance()
        {
            return Nested.Instance;
        }
    }
}
