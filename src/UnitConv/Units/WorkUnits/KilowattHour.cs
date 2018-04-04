using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.WorkUnits
{
    public class KilowattHour : WorkUnit
    {
        private class Nested
        {
            internal static readonly KilowattHour Instance = new KilowattHour();
        }

        private KilowattHour()
        {

        }

        public static KilowattHour GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "千瓦·时" },
                { Languages.English, "kW·h" }
            };
        }

        protected override void InitRate()
        {
            _rate = 3600000m;
        }
    }
}
