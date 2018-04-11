using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Converter
{
    public class DataConverter : ConverterBase<Data, DataUnit>
    {
        private class Nested
        {
            internal static readonly DataConverter Instance = new DataConverter();
        }

        private DataConverter()
        {

        }

        public static DataConverter GetInstance()
        {
            return Nested.Instance;
        }
    }
}
