using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.AreaUnits
{
    class SquareFoot : AreaUnit
    {
        private SquareFoot()
        {

        }

        private static readonly SquareFoot _instance = new SquareFoot();

        public static SquareFoot GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "平方英尺" },
                { Languages.English, "sq.ft" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.3048m * 0.3048m;
        }
    }
}
