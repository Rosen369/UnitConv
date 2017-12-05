using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.LengthUnits
{
    public class Fathom : LengthUnit
    {
        private Fathom()
        {

        }

        private static readonly Fathom _instance = new Fathom();

        public static Fathom GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.ChineseSimplify, "英寻" },
                { Languages.English, "fm" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1.8288m;
        }
    }
}
