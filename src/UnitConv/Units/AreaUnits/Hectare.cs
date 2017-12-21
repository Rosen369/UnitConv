using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.AreaUnits
{
    class Hectare : AreaUnit
    {
        private Hectare()
        {

        }

        private static readonly Hectare _instance = new Hectare();

        public static Hectare GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.ChineseSimplify, "公顷" },
                { Languages.English, "ha" }
            };
        }

        protected override void InitRate()
        {
            _rate = 10000m;
        }
    }
}
