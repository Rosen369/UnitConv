using System;
using System.Collections.Generic;
using System.Text;
using UnitConv.Units;

namespace UnitConv
{
    public abstract class SpeedUnit : Unit
    {
        public static SpeedUnit InchPerSecond
        {
            get
            {
                return Units.SpeedUnits.InchPerSecond.GetInstance();
            }
        }

        public static SpeedUnit KilometerPerHour
        {
            get
            {
                return Units.SpeedUnits.KilometerPerHour.GetInstance();
            }
        }

        public static SpeedUnit KilometerPerSecond
        {
            get
            {
                return Units.SpeedUnits.KilometerPerSecond.GetInstance();
            }
        }

        public static SpeedUnit Mach
        {
            get
            {
                return Units.SpeedUnits.Mach.GetInstance();
            }
        }

        public static SpeedUnit MeterPerSecond
        {
            get
            {
                return Units.SpeedUnits.MeterPerSecond.GetInstance();
            }
        }

        public static SpeedUnit MilePerHour
        {
            get
            {
                return Units.SpeedUnits.MilePerHour.GetInstance();
            }
        }
    }
}
