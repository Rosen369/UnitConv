using System;
using System.Collections.Generic;
using System.Text;
using UnitConv.Converter;
using UnitConv.Units;

namespace UnitConv
{
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

