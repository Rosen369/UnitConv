using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.WeightUnits
{
    public class Milligram : WeightUnit
    {
        private Milligram()
        {

        }

        private static readonly Milligram _instance = new Milligram();

        public static Milligram GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "毫克" },
                { Languages.English, "mg" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.000001m;
        }
    }
}
