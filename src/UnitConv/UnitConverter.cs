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
    }
}

