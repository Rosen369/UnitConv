using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.WorkUnits
{
    public class Calorie : WorkUnit
    {
        private Calorie()
        {

        }

        private static readonly Calorie _instance = new Calorie();

        public static Calorie GetInstance()
        {
            return _instance;
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
