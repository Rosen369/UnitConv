using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Converter
{
    public class WeightConverter : ConverterBase<Weight, WeightUnit>
    {
        private class Nested
        {
            internal static readonly WeightConverter Instance = new WeightConverter();
        }

        private WeightConverter()
        {

        }

        public static WeightConverter GetInstance()
        {
            return Nested.Instance;
        }
    }
}
