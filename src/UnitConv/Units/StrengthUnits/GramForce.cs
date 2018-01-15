using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.StrengthUnits
{
    public class GramForce : StrengthUnit
    {
        private GramForce()
        {

        }

        private static readonly GramForce _instance = new GramForce();

        public static GramForce GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "克力" },
                { Languages.English, "gf" }
            };
        }

        protected override void InitRate()
        {
            _rate = 9.806650m / 1000m;
        }
    }
}
