using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.PressureUnits
{
    public class MillimeterOfMercury : PressureUnit
    {
        private class Nested
        {
            internal static readonly MillimeterOfMercury Instance = new MillimeterOfMercury();
        }

        private MillimeterOfMercury()
        {

        }

        public static MillimeterOfMercury GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "毫米汞柱" },
                { Languages.English, "millimeter of mercury" },
                { Languages.Symbol, "mmHg" }
            };
        }

        protected override void InitRate()
        {
            _rate = 101325m / 760m;
        }
    }
}
