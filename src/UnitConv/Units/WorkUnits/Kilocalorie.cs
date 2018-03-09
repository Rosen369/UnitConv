using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.WorkUnits
{
    public class Kilocalorie : WorkUnit
    {
        private Kilocalorie()
        {

        }

        private static readonly Kilocalorie _instance = new Kilocalorie();

        public static Kilocalorie GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "千卡" },
                { Languages.English, "kcal" }
            };
        }

        protected override void InitRate()
        {
            _rate = 4185.851820846m;
        }
    }
}
