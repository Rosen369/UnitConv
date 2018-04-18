using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.WeightUnits
{
    public class Gram : WeightUnit
    {
        private class Nested
        {
            internal static readonly Gram Instance = new Gram();
        }

        private Gram()
        {

        }

        public static Gram GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "克" },
                { Languages.English, "gram" },
                { Languages.Symbol, "g" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.001m;
        }
    }
}
