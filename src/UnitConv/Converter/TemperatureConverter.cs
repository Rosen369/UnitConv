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
        private TemperatureConverter()
        {

        }

        private static TemperatureConverter _instance = new TemperatureConverter();

        public static TemperatureConverter GetInstance()
        {
            return _instance;
        }
    }
}
