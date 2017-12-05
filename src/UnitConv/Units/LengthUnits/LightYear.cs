using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.LengthUnits
{
    public class LightYear : LengthUnit
    {
        private LightYear()
        {

        }

        private static readonly LightYear _instance = new LightYear();

        public static LightYear GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.ChineseSimplify, "光年" },
                { Languages.English, "ly" }
            };
        }

        protected override void InitRate()
        {
            _rate = 9460730472580800m;
        }
    }
}
