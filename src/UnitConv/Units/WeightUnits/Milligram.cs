using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.WeightUnits
{
    public class Milligram : WeightUnit
    {
        private class Nested
        {
            internal static readonly Milligram Instance = new Milligram();
        }

        private Milligram()
        {

        }

        public static Milligram GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "毫克" },
                { Languages.English, "milligram" },
                { Languages.Symbol, "mg" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.000001m;
        }
    }
}
