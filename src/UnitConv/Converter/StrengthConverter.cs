using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Converter
{
    public class StrengthConverter : ConverterBase<Strength, StrengthUnit>
    {
        private StrengthConverter()
        {

        }

        private static StrengthConverter _instance = new StrengthConverter();

        public static StrengthConverter GetInstance()
        {
            return _instance;
        }
    }
}
