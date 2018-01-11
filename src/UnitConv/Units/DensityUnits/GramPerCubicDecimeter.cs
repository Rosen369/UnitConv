using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.DensityUnits
{
    class GramPerCubicDecimeter : DensityUnit
    {
        private GramPerCubicDecimeter()
        {

        }

        private static readonly GramPerCubicDecimeter _instance = new GramPerCubicDecimeter();

        public static GramPerCubicDecimeter GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "克/立方分米" },
                { Languages.English, "g/dm³" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1m;
        }
    }
}
