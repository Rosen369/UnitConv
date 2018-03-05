using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.WeightUnits
{
    public class Pound : WeightUnit
    {
        private Pound()
        {

        }

        private static readonly Pound _instance = new Pound();

        public static Pound GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "磅" },
                { Languages.English, "lb" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.45359237m;
        }
    }
}
