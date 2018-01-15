using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.StrengthUnits
{
    public class KilopoundForce : StrengthUnit
    {
        private KilopoundForce()
        {

        }

        private static readonly KilopoundForce _instance = new KilopoundForce();

        public static KilopoundForce GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "千磅力" },
                { Languages.English, "kip" }
            };
        }

        protected override void InitRate()
        {
            _rate = 4448.221615m;
        }
    }
}
