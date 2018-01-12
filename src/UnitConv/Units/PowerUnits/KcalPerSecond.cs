using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.PowerUnits
{
    public class KcalPerSecond : PowerUnit
    {
        private KcalPerSecond()
        {

        }

        private static readonly KcalPerSecond _instance = new KcalPerSecond();

        public static KcalPerSecond GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "千卡/秒" },
                { Languages.English, "kcal/s" }
            };
        }

        protected override void InitRate()
        {
            _rate = 4184.1004m;
        }
    }
}
