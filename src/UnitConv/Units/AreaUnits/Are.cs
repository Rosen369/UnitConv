using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.AreaUnits
{
    class Are : AreaUnit
    {
        private Are()
        {

        }

        private static readonly Are _instance = new Are();

        public static Are GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "公亩" },
                { Languages.English, "are" }
            };
        }

        protected override void InitRate()
        {
            _rate = 100m;
        }
    }
}
