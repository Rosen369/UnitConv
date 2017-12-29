using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Converter
{
    /// <summary>
    /// length unit converter 
    /// </summary>
    public class LengthConverter : ConverterBase<Length, LengthUnit>
    {
        private LengthConverter()
        {

        }

        private static LengthConverter _instance = new LengthConverter();

        public static LengthConverter GetInstance()
        {
            return _instance;
        }
    }
}
