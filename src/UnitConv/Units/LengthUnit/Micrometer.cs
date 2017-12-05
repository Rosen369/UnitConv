using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.LengthUnit
{
    public class Micrometer : LengthUnit
    {
        private Micrometer()
        {

        }

        private static readonly Micrometer _instance = new Micrometer();

        public static Micrometer GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.ChineseSimplify, "微米" },
                { Languages.English, "um" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.000001m;
        }
    }
}
