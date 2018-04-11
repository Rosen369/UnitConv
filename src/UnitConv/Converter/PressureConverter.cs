using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Converter
{
    public class PressureConverter : ConverterBase<Pressure, PressureUnit>
    {
        private class Nested
        {
            internal static readonly PressureConverter Instance = new PressureConverter();
        }

        private PressureConverter()
        {

        }

        public static PressureConverter GetInstance()
        {
            return Nested.Instance;
        }
    }
}
