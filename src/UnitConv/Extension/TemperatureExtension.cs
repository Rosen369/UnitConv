using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Extension
{
    public static class TemperatureExtension
    {
        public static Temperature ToCelsius(this Temperature temperature)
        {
            return temperature.ConvertValue(TemperatureUnit.Celsius);
        }

        public static Temperature ToFahrenheit(this Temperature temperature)
        {
            return temperature.ConvertValue(TemperatureUnit.Fahrenheit);
        }

        public static Temperature ToKelvin(this Temperature temperature)
        {
            return temperature.ConvertValue(TemperatureUnit.Kelvin);
        }
    }
}
