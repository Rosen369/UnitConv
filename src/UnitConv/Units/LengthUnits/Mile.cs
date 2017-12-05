using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.LengthUnits
{
    public class Mile : LengthUnit
    {
        private Mile()
        {

        }

        private static readonly Mile _instance = new Mile();

        public static Mile GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.ChineseSimplify, "英里" },
                { Languages.English, "mi" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.304794m * 3m * 1760m;
        }
    }
}
