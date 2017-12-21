using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.AreaUnits
{
    class SquareYard : AreaUnit
    {
        private SquareYard()
        {

        }

        private static readonly SquareYard _instance = new SquareYard();

        public static SquareYard GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.ChineseSimplify, "平方码" },
                { Languages.English, "sq.yd" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.3048m * 0.3048m * 9m;
        }
    }
}
