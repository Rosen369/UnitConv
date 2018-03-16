using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Converter
{
    public class WeightConverter : ConverterBase<Weight, WeightUnit>
    {
        private WeightConverter()
        {

        }

        private static WeightConverter _instance = new WeightConverter();

        public static WeightConverter GetInstance()
        {
            return _instance;
        }
    }
}
