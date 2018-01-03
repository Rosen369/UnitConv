using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.DataUnits
{
    class Megabyte : DataUnit
    {
        private Megabyte()
        {

        }

        private static readonly Megabyte _instance = new Megabyte();

        public static Megabyte GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "兆字节" },
                { Languages.English, "MB" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1 / 1024m / 1024m;
        }
    }
}
