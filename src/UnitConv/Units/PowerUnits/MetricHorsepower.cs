using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.PowerUnits
{
    public class MetricHorsepower : PowerUnit
    {
        private class Nested
        {
            internal static readonly MetricHorsepower Instance = new MetricHorsepower();
        }

        private MetricHorsepower()
        {

        }

        public static MetricHorsepower GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "米制马力" },
                { Languages.English, "metric horsepower" },
                { Languages.Symbol, "ps" }
            };
        }

        protected override void InitRate()
        {
            _rate = 9.80665m * 75m;
        }
    }
}
