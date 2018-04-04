using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.DataUnits
{
    class Petabyte : DataUnit
    {
        private class Nested
        {
            internal static readonly Petabyte Instance = new Petabyte();
        }

        private Petabyte()
        {

        }

        public static Petabyte GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "拍字节" },
                { Languages.English, "PB" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1 / 1024m / 1024m / 1024m / 1024m / 1024m;
        }
    }
}
