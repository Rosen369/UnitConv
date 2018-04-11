using System;
using System.Collections.Generic;
using System.Text;
using UnitConv.Units;

namespace UnitConv
{
    public abstract class TemperatureUnit : Unit
    {
        public static TemperatureUnit Celsius
        {
            get
            {
                return Units.TemperatureUnits.Celsius.GetInstance();
            }
        }

        public static TemperatureUnit Fahrenheit
        {
            get
            {
                return Units.TemperatureUnits.Fahrenheit.GetInstance();
            }
        }

        public static TemperatureUnit Kelvin
        {
            get
            {
                return Units.TemperatureUnits.Kelvin.GetInstance();
            }
        }
    }
}
