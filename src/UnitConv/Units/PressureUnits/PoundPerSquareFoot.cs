using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.PressureUnits
{
    public class PoundPerSquareFoot : PressureUnit
    {
        private class Nested
        {
            internal static readonly PoundPerSquareFoot Instance = new PoundPerSquareFoot();
        }

        private PoundPerSquareFoot()
        {

        }

        public static PoundPerSquareFoot GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "磅力/平方英尺" },
                { Languages.English, "psf" }
            };
        }

        protected override void InitRate()
        {
            _rate = 6894.757m / 144m;
        }
    }
}
