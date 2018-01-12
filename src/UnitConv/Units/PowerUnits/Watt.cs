using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.PowerUnits
{
    public class Watt : PowerUnit
    {
        private Watt()
        {

        }

        private static readonly Watt _instance = new Watt();

        public static Watt GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "瓦" },
                { Languages.English, "W" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1m;
        }
    }
}
