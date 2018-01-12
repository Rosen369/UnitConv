using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.PressureUnits
{
    public class PoundPerSquareFoot : PressureUnit
    {
        private PoundPerSquareFoot()
        {

        }

        private static readonly PoundPerSquareFoot _instance = new PoundPerSquareFoot();

        public static PoundPerSquareFoot GetInstance()
        {
            return _instance;
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
