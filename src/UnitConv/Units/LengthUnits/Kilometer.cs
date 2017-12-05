using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.LengthUnits
{
    public class Kilometer : LengthUnit
    {
        private Kilometer()
        {

        }

        private static readonly Kilometer _instance = new Kilometer();

        public static Kilometer GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.ChineseSimplify, "千米" },
                { Languages.English, "km" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1000m;
        }
    }
}
