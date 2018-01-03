using System;
using System.Collections.Generic;
using System.Text;
using UnitConv.Units;

namespace UnitConv
{
    public abstract class DataUnit : Unit
    {
        public static DataUnit Bit
        {
            get
            {
                return Units.DataUnits.Bit.GetInstance();
            }
        }

        public static DataUnit Byte
        {
            get
            {
                return Units.DataUnits.Byte.GetInstance();
            }
        }

        public static DataUnit Gigabyte
        {
            get
            {
                return Units.DataUnits.Gigabyte.GetInstance();
            }
        }

        public static DataUnit Kilobyte
        {
            get
            {
                return Units.DataUnits.Kilobyte.GetInstance();
            }
        }

        public static DataUnit Megabyte
        {
            get
            {
                return Units.DataUnits.Megabyte.GetInstance();
            }
        }

        public static DataUnit Petabyte
        {
            get
            {
                return Units.DataUnits.Petabyte.GetInstance();
            }
        }

        public static DataUnit Terabyte
        {
            get
            {
                return Units.DataUnits.Terabyte.GetInstance();
            }
        }
    }
}
