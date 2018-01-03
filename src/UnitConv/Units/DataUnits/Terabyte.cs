using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.DataUnits
{
    class Terabyte : DataUnit
    {
        private Terabyte()
        {

        }

        private static readonly Terabyte _instance = new Terabyte();

        public static Terabyte GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "太字节" },
                { Languages.English, "TB" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1 / 1024m / 1024m / 1024m / 1024m;
        }
    }
}
