using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.AreaUnits
{
    class SquareDeciMeter : AreaUnit
    {
        private SquareDeciMeter()
        {

        }

        private static readonly SquareDeciMeter _instance = new SquareDeciMeter();

        public static SquareDeciMeter GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "平方分米" },
                { Languages.English, "dm²" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.01m;
        }
    }
}
