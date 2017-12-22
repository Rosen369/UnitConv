using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.AreaUnits
{
    class SquareInch : AreaUnit
    {
        private SquareInch()
        {

        }

        private static readonly SquareInch _instance = new SquareInch();

        public static SquareInch GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "平方英寸" },
                { Languages.English, "sq.in" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.3048m * 0.3048m / 144m;
        }
    }
}
