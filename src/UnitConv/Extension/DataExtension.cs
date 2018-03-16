using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Extension
{
    public static class DataExtension
    {
        public static Data ToBit(this Data data)
        {
            return data.ConvertValue(DataUnit.Bit);
        }

        public static Data ToByte(this Data data)
        {
            return data.ConvertValue(DataUnit.Byte);
        }

        public static Data ToGigabyte(this Data data)
        {
            return data.ConvertValue(DataUnit.Gigabyte);
        }

        public static Data ToKilobyte(this Data data)
        {
            return data.ConvertValue(DataUnit.Kilobyte);
        }

        public static Data ToMegabyte(this Data data)
        {
            return data.ConvertValue(DataUnit.Megabyte);
        }

        public static Data ToPetabyte(this Data data)
        {
            return data.ConvertValue(DataUnit.Petabyte);
        }

        public static Data ToTerabyte(this Data data)
        {
            return data.ConvertValue(DataUnit.Terabyte);
        }
    }
}
