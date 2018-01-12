using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.PowerUnits
{
    public class FootPoundPerSecond : PowerUnit
    {
        private FootPoundPerSecond()
        {

        }

        private static readonly FootPoundPerSecond _instance = new FootPoundPerSecond();

        public static FootPoundPerSecond GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "英尺·磅/秒" },
                { Languages.English, "ft·lb/s" }
            };
        }

        protected override void InitRate()
        {
            _rate = 745.699872m / 550m;
        }
    }
}
