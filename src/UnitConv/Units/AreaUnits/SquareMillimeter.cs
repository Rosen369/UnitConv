using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.AreaUnits
{
    class SquareMillimeter : AreaUnit
    {
        private SquareMillimeter()
        {

        }

        private static readonly SquareMillimeter _instance = new SquareMillimeter();

        public static SquareMillimeter GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.ChineseSimplify, "平方毫米" },
                { Languages.English, "mm²" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.000001m;
        }
    }
}
