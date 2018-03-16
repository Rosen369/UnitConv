using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Extension
{
    public static class PowerExtension
    {
        public static Power ToBritishHorsepower(this Power power)
        {
            return power.ConvertValue(PowerUnit.BritishHorsepower);
        }

        public static Power ToBritishThermalUnitPerSecond(this Power power)
        {
            return power.ConvertValue(PowerUnit.BritishThermalUnitPerSecond);
        }

        public static Power ToFootPoundPerSecond(this Power power)
        {
            return power.ConvertValue(PowerUnit.FootPoundPerSecond);
        }

        public static Power ToJoulePerSecond(this Power power)
        {
            return power.ConvertValue(PowerUnit.JoulePerSecond);
        }

        public static Power ToKcalPerSecond(this Power power)
        {
            return power.ConvertValue(PowerUnit.KcalPerSecond);
        }

        public static Power ToKilogramMeterPerSecond(this Power power)
        {
            return power.ConvertValue(PowerUnit.KilogramMeterPerSecond);
        }

        public static Power ToKilowatt(this Power power)
        {
            return power.ConvertValue(PowerUnit.Kilowatt);
        }

        public static Power ToMetricHorsepower(this Power power)
        {
            return power.ConvertValue(PowerUnit.MetricHorsepower);
        }

        public static Power ToNewtonMeterPerSecond(this Power power)
        {
            return power.ConvertValue(PowerUnit.NewtonMeterPerSecond);
        }

        public static Power ToWatt(this Power power)
        {
            return power.ConvertValue(PowerUnit.Watt);
        }
    }
}
