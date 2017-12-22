using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.AreaUnits
{
    class SquareKilometer : AreaUnit
    {
        private SquareKilometer()
        {

        }

        private static readonly SquareKilometer _instance = new SquareKilometer();

        public static SquareKilometer GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "平方千米" },
                { Languages.English, "km²" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1000000m;
        }
    }
}
