using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.WeightUnits
{
    public class Kilogram : WeightUnit
    {
        private class Nested
        {
            internal static readonly Kilogram Instance = new Kilogram();
        }

        private Kilogram()
        {

        }

        public static Kilogram GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "千克" },
                { Languages.English, "kg" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1m;
        }
    }
}
