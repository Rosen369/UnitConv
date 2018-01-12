using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.PowerUnits
{
    public class Kilowatt : PowerUnit
    {
        private Kilowatt()
        {

        }

        private static readonly Kilowatt _instance = new Kilowatt();

        public static Kilowatt GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "千瓦" },
                { Languages.English, "kW" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1000m;
        }
    }
}
