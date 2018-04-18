using System;
using System.Collections.Generic;
using System.Text;
using UnitConv.Converter;
using UnitConv.Units;

namespace UnitConv
{
    /// <summary>
    /// contianer of unit converters
    /// </summary>
    public static class UnitConverter
    {
        public static LengthConverter Length
        {
            get
            {
                return LengthConverter.GetInstance();
            }
        }

        public static AreaConverter Area
        {
            get
            {
                return AreaConverter.GetInstance();
            }
        }

        public static DataConverter Data
        {
            get
            {
                return DataConverter.GetInstance();
            }
        }

        public static PowerConverter Power
        {
            get
            {
                return PowerConverter.GetInstance();
            }
        }

        public static PressureConverter Pressure
        {
            get
            {
                return PressureConverter.GetInstance();
            }
        }

        public static SpeedConverter Speed
        {
            get
            {
                return SpeedConverter.GetInstance();
            }
        }

        public static StrengthConverter Strength
        {
            get
            {
                return StrengthConverter.GetInstance();
            }
        }

        public static VolumeConverter Volume
        {
            get
            {
                return VolumeConverter.GetInstance();
            }
        }

        public static WeightConverter Weight
        {
            get
            {
                return WeightConverter.GetInstance();
            }
        }

        public static WorkConverter Work
        {
            get
            {
                return WorkConverter.GetInstance();
            }
        }

        public static TemperatureConverter TemperatureConverter
        {
            get
            {
                return TemperatureConverter.GetInstance();
            }
        }
    }
}

