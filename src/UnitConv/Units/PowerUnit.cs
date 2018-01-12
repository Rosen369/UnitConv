using System;
using System.Collections.Generic;
using System.Text;
using UnitConv.Units;

namespace UnitConv
{
    public abstract class PowerUnit : Unit
    {
        public static PowerUnit Watt
        {
            get
            {
                return Units.PowerUnits.Watt.GetInstance();
            }
        }

        public static PowerUnit BritishHorsepower
        {
            get
            {
                return Units.PowerUnits.BritishHorsepower.GetInstance();
            }
        }

        public static PowerUnit BritishThermalUnitPerSecond
        {
            get
            {
                return Units.PowerUnits.BritishThermalUnitPerSecond.GetInstance();
            }
        }

        public static PowerUnit FootPoundPerSecond
        {
            get
            {
                return Units.PowerUnits.FootPoundPerSecond.GetInstance();
            }
        }

        public static PowerUnit JoulePerSecond
        {
            get
            {
                return Units.PowerUnits.JoulePerSecond.GetInstance();
            }
        }

        public static PowerUnit KcalPerSecond
        {
            get
            {
                return Units.PowerUnits.KcalPerSecond.GetInstance();
            }
        }

        public static PowerUnit KilogramMeterPerSecond
        {
            get
            {
                return Units.PowerUnits.KilogramMeterPerSecond.GetInstance();
            }
        }

        public static PowerUnit Kilowatt
        {
            get
            {
                return Units.PowerUnits.Kilowatt.GetInstance();
            }
        }

        public static PowerUnit MetricHorsepower
        {
            get
            {
                return Units.PowerUnits.MetricHorsepower.GetInstance();
            }
        }

        public static PowerUnit NewtonMeterPerSecond
        {
            get
            {
                return Units.PowerUnits.NewtonMeterPerSecond.GetInstance();
            }
        }
    }
}
