using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.StrengthUnits
{
    public class Newton : StrengthUnit
    {
        private Newton()
        {

        }

        private static readonly Newton _instance = new Newton();

        public static Newton GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "牛" },
                { Languages.English, "N" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1m;
        }
    }
}
