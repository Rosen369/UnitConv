using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.PowerUnits
{
    public class JoulePerSecond : PowerUnit
    {
        private JoulePerSecond()
        {

        }

        private static readonly JoulePerSecond _instance = new JoulePerSecond();

        public static JoulePerSecond GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "焦耳/秒" },
                { Languages.English, "J/s" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1m;
        }
    }
}
