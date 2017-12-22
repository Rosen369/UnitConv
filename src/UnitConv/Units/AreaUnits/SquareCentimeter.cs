using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.AreaUnits
{
    class SquareCentimeter : AreaUnit
    {
        private SquareCentimeter()
        {

        }

        private static readonly SquareCentimeter _instance = new SquareCentimeter();

        public static SquareCentimeter GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "平方厘米" },
                { Languages.English, "cm²" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.0001m;
        }
    }
}
