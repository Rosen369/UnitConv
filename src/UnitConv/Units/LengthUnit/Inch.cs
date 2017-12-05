using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.LengthUnit
{
    public class Inch : LengthUnit
    {
        private Inch()
        {

        }

        private static readonly Inch _instance = new Inch();

        public static Inch GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.ChineseSimplify, "英寸" },
                { Languages.English, "in" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.304794m / 12m;
        }
    }
}
