using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.PressureUnits
{
    public class PoundPerSquareInch : PressureUnit
    {
        private class Nested
        {
            internal static readonly PoundPerSquareInch Instance = new PoundPerSquareInch();
        }

        private PoundPerSquareInch()
        {

        }

        public static PoundPerSquareInch GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "磅力/平方英寸" },
                { Languages.English, "pound per square inch" },
                { Languages.Symbol, "psi" }
            };
        }

        protected override void InitRate()
        {
            _rate = 6894.757m;
        }
    }
}
