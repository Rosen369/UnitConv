using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.WeightUnits
{
    public class Ounce : WeightUnit
    {
        private class Nested
        {
            internal static readonly Ounce Instance = new Ounce();
        }

        private Ounce()
        {

        }

        public static Ounce GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "盎司" },
                { Languages.English, "oz" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.45359237m / 16m;
        }
    }
}
