using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.WeightUnits
{
    public class Gram : WeightUnit
    {
        private Gram()
        {

        }

        private static readonly Gram _instance = new Gram();

        public static Gram GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "克" },
                { Languages.English, "g" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.001m;
        }
    }
}
