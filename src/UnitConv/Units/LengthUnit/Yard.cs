using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.LengthUnit
{
    public class Yard : LengthUnit
    {
        private Yard()
        {

        }

        private static readonly Yard _instance = new Yard();

        public static Yard GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.ChineseSimplify, "码" },
                { Languages.English, "yd" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.304794m * 3m;
        }
    }
}
