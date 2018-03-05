using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.WeightUnits
{
    public class Ton : WeightUnit
    {
        private Ton()
        {

        }

        private static readonly Ton _instance = new Ton();

        public static Ton GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "吨" },
                { Languages.English, "t" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1000m;
        }
    }
}
