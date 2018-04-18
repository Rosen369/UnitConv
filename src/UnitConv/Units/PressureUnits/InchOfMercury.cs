using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.PressureUnits
{
    public class InchOfMercury : PressureUnit
    {
        private class Nested
        {
            internal static readonly InchOfMercury Instance = new InchOfMercury();
        }

        private InchOfMercury()
        {

        }

        public static InchOfMercury GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "英寸汞柱" },
                { Languages.English, "inch of mercury" },
                { Languages.Symbol, "inHg" }
            };
        }

        protected override void InitRate()
        {
            _rate = 101325m / 760m * 25.4m;
        }
    }
}
