using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Converter
{
    public class DataConverter : ConverterBase<Data, DataUnit>
    {
        private DataConverter()
        {

        }

        private static DataConverter _instance = new DataConverter();

        public static DataConverter GetInstance()
        {
            return _instance;
        }
    }
}
