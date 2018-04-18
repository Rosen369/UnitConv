using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.PowerUnits
{
    public class Kilowatt : PowerUnit
    {
        private class Nested
        {
            internal static readonly Kilowatt Instance = new Kilowatt();
        }

        private Kilowatt()
        {

        }

        public static Kilowatt GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "千瓦" },
                { Languages.English, "kilowatt" },
                { Languages.Symbol, "kW" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1000m;
        }
    }
}
