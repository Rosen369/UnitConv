using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.DataUnits
{
    class Kilobyte : DataUnit
    {
        private class Nested
        {
            internal static readonly Kilobyte Instance = new Kilobyte();
        }

        private Kilobyte()
        {

        }

        public static Kilobyte GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "千字节" },
                { Languages.English, "KB" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1 / 1024m;
        }
    }
}
