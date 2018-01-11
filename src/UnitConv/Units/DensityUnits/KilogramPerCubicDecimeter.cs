using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.DensityUnits
{
    class KilogramPerCubicDecimeter : DensityUnit
    {
        private KilogramPerCubicDecimeter()
        {

        }

        private static readonly KilogramPerCubicDecimeter _instance = new KilogramPerCubicDecimeter();

        public static KilogramPerCubicDecimeter GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "千克/立方分米" },
                { Languages.English, "kg/dm³" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1000m;
        }
    }
}
