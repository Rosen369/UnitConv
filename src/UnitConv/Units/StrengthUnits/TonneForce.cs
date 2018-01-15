using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.StrengthUnits
{
    public class TonneForce : StrengthUnit
    {
        private TonneForce()
        {

        }

        private static readonly TonneForce _instance = new TonneForce();

        public static TonneForce GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "公吨力" },
                { Languages.English, "tf" }
            };
        }

        protected override void InitRate()
        {
            _rate = 9806.650000m;
        }
    }
}
