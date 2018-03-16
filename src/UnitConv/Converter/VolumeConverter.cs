using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Converter
{
    public class VolumeConverter : ConverterBase<Volume, VolumeUnit>
    {
        private VolumeConverter()
        {

        }

        private static VolumeConverter _instance = new VolumeConverter();

        public static VolumeConverter GetInstance()
        {
            return _instance;
        }
    }
}
