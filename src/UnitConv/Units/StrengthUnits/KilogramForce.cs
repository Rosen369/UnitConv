using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.StrengthUnits
{
    public class KilogramForce : StrengthUnit
    {
        private KilogramForce()
        {

        }

        private static readonly KilogramForce _instance = new KilogramForce();

        public static KilogramForce GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "千克力" },
                { Languages.English, "kgf" }
            };
        }

        protected override void InitRate()
        {
            _rate = 9.806650m;
        }
    }
}
