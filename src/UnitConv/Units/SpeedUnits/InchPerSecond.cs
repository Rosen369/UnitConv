using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.SpeedUnits
{
    public class InchPerSecond : SpeedUnit
    {
        private InchPerSecond()
        {

        }

        private static readonly InchPerSecond _instance = new InchPerSecond();

        public static InchPerSecond GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "英寸/秒" },
                { Languages.English, "in/s" }
            };
        }

        protected override void InitRate()
        {
            _rate = 25.400000m / 1000m;
        }
    }
}
