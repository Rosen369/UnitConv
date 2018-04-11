using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Converter
{
    public class StrengthConverter : ConverterBase<Strength, StrengthUnit>
    {
        private class Nested
        {
            internal static readonly StrengthConverter Instance = new StrengthConverter();
        }

        private StrengthConverter()
        {

        }

        public static StrengthConverter GetInstance()
        {
            return Nested.Instance;
        }
    }
}
