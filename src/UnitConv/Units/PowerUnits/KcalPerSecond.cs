using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.PowerUnits
{
    public class KcalPerSecond : PowerUnit
    {
        private class Nested
        {
            internal static readonly KcalPerSecond Instance = new KcalPerSecond();
        }

        private KcalPerSecond()
        {

        }

        public static KcalPerSecond GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "千卡/秒" },
                { Languages.English, "kilocalories per second" },
                { Languages.Symbol, "kcal/s" }
            };
        }

        protected override void InitRate()
        {
            _rate = 4184.1004m;
        }
    }
}
