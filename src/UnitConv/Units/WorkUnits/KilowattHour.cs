using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.WorkUnits
{
    public class KilowattHour : WorkUnit
    {
        private KilowattHour()
        {

        }

        private static readonly KilowattHour _instance = new KilowattHour();

        public static KilowattHour GetInstance()
        {
            return _instance;
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
