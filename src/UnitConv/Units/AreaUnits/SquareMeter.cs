using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.AreaUnits
{
    class SquareMeter : AreaUnit
    {
        private SquareMeter()
        {

        }

        private static readonly SquareMeter _instance = new SquareMeter();

        public static SquareMeter GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.ChineseSimplify, "平方米" },
                { Languages.English, "m²" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1m;
        }
    }
}
