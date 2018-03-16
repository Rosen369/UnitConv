using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Converter
{
    public class PowerConverter : ConverterBase<Power, PowerUnit>
    {
        private PowerConverter()
        {

        }

        private static PowerConverter _instance = new PowerConverter();

        public static PowerConverter GetInstance()
        {
            return _instance;
        }
    }
}
