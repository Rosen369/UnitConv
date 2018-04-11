using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Converter
{
    /// <summary>
    /// area unit converter
    /// </summary>
    public class AreaConverter : ConverterBase<Area, AreaUnit>
    {
        private class Nested
        {
            internal static readonly AreaConverter Instance = new AreaConverter();
        }

        private AreaConverter()
        {

        }

        public static AreaConverter GetInstance()
        {
            return Nested.Instance;
        }
    }
}
