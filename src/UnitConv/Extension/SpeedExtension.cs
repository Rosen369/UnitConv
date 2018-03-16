using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Extension
{
    public static class SpeedExtension
    {
        public static Speed ToInchPerSecond(this Speed speed)
        {
            return speed.ConvertValue(SpeedUnit.InchPerSecond);
        }

        public static Speed ToKilometerPerHour(this Speed speed)
        {
            return speed.ConvertValue(SpeedUnit.KilometerPerHour);
        }

        public static Speed ToKilometerPerSecond(this Speed speed)
        {
            return speed.ConvertValue(SpeedUnit.KilometerPerSecond);
        }

        public static Speed ToMach(this Speed speed)
        {
            return speed.ConvertValue(SpeedUnit.Mach);
        }

        public static Speed ToMeterPerSecond(this Speed speed)
        {
            return speed.ConvertValue(SpeedUnit.MeterPerSecond);
        }

        public static Speed ToMilePerHour(this Speed speed)
        {
            return speed.ConvertValue(SpeedUnit.MilePerHour);
        }
    }
}
