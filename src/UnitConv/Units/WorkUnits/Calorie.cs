using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.WorkUnits
{
    public class Calorie : WorkUnit
    {
        private class Nested
        {
            internal static readonly Calorie Instance = new Calorie();
        }

        private Calorie()
        {

        }

        public static Calorie GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "卡" },
                { Languages.English, "cal" }
            };
        }

        protected override void InitRate()
        {
            _rate = 4.185851820846m;
        }
    }
}
