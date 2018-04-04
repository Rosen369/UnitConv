using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.WorkUnits
{
    public class MetricHorsepowerHour : WorkUnit
    {
        private class Nested
        {
            internal static readonly MetricHorsepowerHour Instance = new MetricHorsepowerHour();
        }

        private MetricHorsepowerHour()
        {

        }

        public static MetricHorsepowerHour GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "米制马力·时" },
                { Languages.English, "ps·h" }
            };
        }

        protected override void InitRate()
        {
            _rate = 9.80665m * 75m * 3600m;
        }
    }
}
