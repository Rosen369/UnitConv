using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.LengthUnits
{
    public class LightYear : LengthUnit
    {
        private class Nested
        {
            internal static readonly LightYear Instance = new LightYear();
        }

        private LightYear()
        {

        }

        public static LightYear GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "光年" },
                { Languages.English, "ly" }
            };
        }

        protected override void InitRate()
        {
            _rate = 9460730472580800m;
        }
    }
}
