using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.LengthUnit
{
    public class Millimeter : LengthUnit
    {
        private Millimeter()
        {

        }

        private static readonly Millimeter _instance = new Millimeter();

        public static Millimeter GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.ChineseSimplify, "毫米" },
                { Languages.English, "mm" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.001m;
        }
    }
}
