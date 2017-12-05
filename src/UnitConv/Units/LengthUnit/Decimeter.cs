using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.LengthUnit
{
    public class Decimeter : LengthUnit
    {
        private Decimeter()
        {

        }

        private static readonly Decimeter _instance = new Decimeter();

        public static Decimeter GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.ChineseSimplify, "分米" },
                { Languages.English, "dm" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.1m;
        }
    }
}
