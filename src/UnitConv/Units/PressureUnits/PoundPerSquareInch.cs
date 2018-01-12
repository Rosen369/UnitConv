using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.PressureUnits
{
    public class PoundPerSquareInch : PressureUnit
    {
        private PoundPerSquareInch()
        {

        }

        private static readonly PoundPerSquareInch _instance = new PoundPerSquareInch();

        public static PoundPerSquareInch GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "磅力/平方英寸" },
                { Languages.English, "psi" }
            };
        }

        protected override void InitRate()
        {
            _rate = 6894.757m;
        }
    }
}
