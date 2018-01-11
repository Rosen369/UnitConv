using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.DensityUnits
{
    class KilogramPerCubicMeter : DensityUnit
    {
        private KilogramPerCubicMeter()
        {

        }

        private static readonly KilogramPerCubicMeter _instance = new KilogramPerCubicMeter();

        public static KilogramPerCubicMeter GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "千克/立方米" },
                { Languages.English, "kg/m³" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1m;
        }
    }
}
