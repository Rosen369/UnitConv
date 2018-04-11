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
        private class Nested
        {
            internal static readonly LengthConverter Instance = new LengthConverter();
        }

        private LengthConverter()
        {

        }

        public static LengthConverter GetInstance()
        {
            return Nested.Instance;
        }
    }
}
