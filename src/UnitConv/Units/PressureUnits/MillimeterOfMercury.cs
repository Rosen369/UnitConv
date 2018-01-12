using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.PressureUnits
{
    public class MillimeterOfMercury : PressureUnit
    {
        private MillimeterOfMercury()
        {

        }

        private static readonly MillimeterOfMercury _instance = new MillimeterOfMercury();

        public static MillimeterOfMercury GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "毫米汞柱" },
                { Languages.English, "mmHg" }
            };
        }

        protected override void InitRate()
        {
            _rate = 101325m / 760m;
        }
    }
}
