using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Converter
{
    /// <summary>
    /// temperature unit converter
    /// </summary>
    public class TemperatureConverter : ConverterBase<Temperature, TemperatureUnit>
    {
        private class Nested
        {
            internal static readonly TemperatureConverter Instance = new TemperatureConverter();
        }

        private TemperatureConverter()
        {

        }

        public static TemperatureConverter GetInstance()
        {
            return Nested.Instance;
        }
    }
}
