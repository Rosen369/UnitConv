using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.LengthUnits
{
    public class AstronomicalUnit : LengthUnit
    {
        private AstronomicalUnit()
        {

        }

        private static readonly AstronomicalUnit _instance = new AstronomicalUnit();

        public static AstronomicalUnit GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.ChineseSimplify, "天文单位" },
                { Languages.English, "AU" }
            };
        }

        protected override void InitRate()
        {
            _rate = 149597870700m;
        }
    }
}
