using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.PowerUnits
{
    public class JoulePerSecond : PowerUnit
    {
        private class Nested
        {
            internal static readonly JoulePerSecond Instance = new JoulePerSecond();
        }

        private JoulePerSecond()
        {

        }

        public static JoulePerSecond GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "焦耳/秒" },
                { Languages.English, "joule per second" },
                { Languages.Symbol, "J/s" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1m;
        }
    }
}
