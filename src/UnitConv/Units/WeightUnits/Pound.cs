using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.WeightUnits
{
    public class Pound : WeightUnit
    {
        private class Nested
        {
            internal static readonly Pound Instance = new Pound();
        }

        private Pound()
        {

        }

        public static Pound GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "磅" },
                { Languages.English, "pound" },
                { Languages.Symbol, "lb" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.45359237m;
        }
    }
}
