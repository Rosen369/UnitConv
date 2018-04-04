using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.WeightUnits
{
    public class Quintal : WeightUnit
    {
        private class Nested
        {
            internal static readonly Quintal Instance = new Quintal();
        }

        private Quintal()
        {

        }

        public static Quintal GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "公担" },
                { Languages.English, "q" }
            };
        }

        protected override void InitRate()
        {
            _rate = 100m;
        }
    }
}
