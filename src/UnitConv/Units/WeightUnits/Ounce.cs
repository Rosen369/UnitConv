using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.WeightUnits
{
    public class Ounce : WeightUnit
    {
        private Ounce()
        {

        }

        private static readonly Ounce _instance = new Ounce();

        public static Ounce GetInstance()
        {
            return _instance;
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
