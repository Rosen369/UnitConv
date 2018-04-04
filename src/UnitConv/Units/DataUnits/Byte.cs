using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.DataUnits
{
    class Byte : DataUnit
    {
        private class Nested
        {
            internal static readonly Byte Instance = new Byte();
        }

        private Byte()
        {

        }

        public static Byte GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "字节" },
                { Languages.English, "Byte" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1m;
        }
    }
}
