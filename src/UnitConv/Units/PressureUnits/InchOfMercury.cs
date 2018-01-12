using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.PressureUnits
{
    public class InchOfMercury : PressureUnit
    {
        private InchOfMercury()
        {

        }

        private static readonly InchOfMercury _instance = new InchOfMercury();

        public static InchOfMercury GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "英寸汞柱" },
                { Languages.English, "inHg" }
            };
        }

        protected override void InitRate()
        {
            _rate = 101325m / 760m * 25.4m;
        }
    }
}
