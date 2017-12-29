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
        private AreaConverter()
        {

        }

        private static AreaConverter _instance = new AreaConverter();

        public static AreaConverter GetInstance()
        {
            return _instance;
        }
    }
}
