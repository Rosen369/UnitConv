using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.PressureUnits
{
    public class Pascal : PressureUnit
    {
        private Pascal()
        {

        }

        private static readonly Pascal _instance = new Pascal();

        public static Pascal GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "帕斯卡" },
                { Languages.English, "Pa" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1m;
        }
    }
}
