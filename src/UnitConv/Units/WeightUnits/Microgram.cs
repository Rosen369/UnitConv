using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.WeightUnits
{
    public class Microgram : WeightUnit
    {
        private class Nested
        {
            internal static readonly Microgram Instance = new Microgram();
        }

        private Microgram()
        {

        }

        public static Microgram GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "微克" },
                { Languages.English, "microgram" },
                { Languages.Symbol, "ug" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.000000001m;
        }
    }
}
