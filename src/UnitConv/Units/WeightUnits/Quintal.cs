using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.WeightUnits
{
    public class Quintal : WeightUnit
    {
        private Quintal()
        {

        }

        private static readonly Quintal _instance = new Quintal();

        public static Quintal GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "公担" },
                { Languages.English, "q" }
            };
        }

        protected override void InitRate()
        {
            _rate = 100m;
        }
    }
}
