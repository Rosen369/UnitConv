using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.DataUnits
{
    class Gigabyte : DataUnit
    {
        private Gigabyte()
        {

        }

        private static readonly Gigabyte _instance = new Gigabyte();

        public static Gigabyte GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "千兆字节" },
                { Languages.English, "GB" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1 / 1024m / 1024m / 1024m;
        }
    }
}
