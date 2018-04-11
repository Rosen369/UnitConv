using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Converter
{
    public class VolumeConverter : ConverterBase<Volume, VolumeUnit>
    {
        private class Nested
        {
            internal static readonly VolumeConverter Instance = new VolumeConverter();
        }

        private VolumeConverter()
        {

        }

        public static VolumeConverter GetInstance()
        {
            return Nested.Instance;
        }
    }
}
