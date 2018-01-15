using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.StrengthUnits
{
    public class PoundForce : StrengthUnit
    {
        private PoundForce()
        {

        }

        private static readonly PoundForce _instance = new PoundForce();

        public static PoundForce GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "磅力" },
                { Languages.English, "lbf" }
            };
        }

        protected override void InitRate()
        {
            _rate = 4.448222m;
        }
    }
}
