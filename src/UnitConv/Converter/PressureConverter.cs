using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Converter
{
    public class PressureConverter : ConverterBase<Pressure, PressureUnit>
    {
        private PressureConverter()
        {

        }

        private static PressureConverter _instance = new PressureConverter();

        public static PressureConverter GetInstance()
        {
            return _instance;
        }
    }
}
