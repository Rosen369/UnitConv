using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.LengthUnit
{
    public class Meter : LengthUnit
    {
        private Meter()
        {

        }

        private static readonly Meter _instance = new Meter();

        public static Meter GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.ChineseSimplify, "米" },
                { Languages.English, "m" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1;
        }
    }
}
