using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.WorkUnits
{
    public class Kilocalorie : WorkUnit
    {
        private class Nested
        {
            internal static readonly Kilocalorie Instance = new Kilocalorie();
        }

        private Kilocalorie()
        {

        }

        public static Kilocalorie GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "千卡" },
                { Languages.English, "kilocalorie" },
                { Languages.Symbol, "kcal" }
            };
        }

        protected override void InitRate()
        {
            _rate = 4185.851820846m;
        }
    }
}
