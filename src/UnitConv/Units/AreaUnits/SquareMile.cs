using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.AreaUnits
{
    class SquareMile : AreaUnit
    {
        private SquareMile()
        {

        }

        private static readonly SquareMile _instance = new SquareMile();

        public static SquareMile GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.ChineseSimplify, "平方英里" },
                { Languages.English, "sq.mi" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.3048m * 3m * 1760m * 0.3048m * 3m * 1760m;
        }
    }
}
