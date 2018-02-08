using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.WeightUnits
{
    public class Kilogram : WeightUnit
    {
        private Kilogram()
        {

        }

        private static readonly Kilogram _instance = new Kilogram();

        public static Kilogram GetInstance()
        {
            return _instance;
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
