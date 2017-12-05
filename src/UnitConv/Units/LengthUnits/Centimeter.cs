using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.LengthUnits
{
    public class Centimeter : LengthUnit
    {
        private Centimeter()
        {

        }

        private static readonly Centimeter _instance = new Centimeter();

        public static Centimeter GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.ChineseSimplify, "厘米" },
                { Languages.English, "cm" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.01m;
        }
    }
}
