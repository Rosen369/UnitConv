using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.LengthUnit
{
    public class Nanometer : LengthUnit
    {
        private Nanometer()
        {

        }

        private static readonly Nanometer _instance = new Nanometer();

        public static Nanometer GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.ChineseSimplify, "纳米" },
                { Languages.English, "nm" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.000000001m;
        }
    }
}
