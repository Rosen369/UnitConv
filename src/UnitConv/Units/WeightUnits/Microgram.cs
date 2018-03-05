using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.WeightUnits
{
    public class Microgram : WeightUnit
    {
        private Microgram()
        {

        }

        private static readonly Microgram _instance = new Microgram();

        public static Microgram GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "微克" },
                { Languages.English, "ug" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.000000001m;
        }
    }
}
