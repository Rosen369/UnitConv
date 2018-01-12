using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.PowerUnits
{
    public class MetricHorsepower : PowerUnit
    {
        private MetricHorsepower()
        {

        }

        private static readonly MetricHorsepower _instance = new MetricHorsepower();

        public static MetricHorsepower GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "米制马力" },
                { Languages.English, "ps" }
            };
        }

        protected override void InitRate()
        {
            _rate = 9.80665m * 75m;
        }
    }
}
