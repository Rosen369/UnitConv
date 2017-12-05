using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.LengthUnit
{
    public class Picometer : LengthUnit
    {
        private Picometer()
        {

        }

        private static readonly Picometer _instance = new Picometer();

        public static Picometer GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.ChineseSimplify, "皮米" },
                { Languages.English, "pm" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.000000000001m;
        }
    }
}
