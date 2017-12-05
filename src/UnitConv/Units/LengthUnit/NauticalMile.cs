using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.LengthUnit
{
    public class NauticalMile : LengthUnit
    {
        private NauticalMile()
        {

        }

        private static readonly NauticalMile _instance = new NauticalMile();

        public static NauticalMile GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.ChineseSimplify, "海里" },
                { Languages.English, "nmi" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1852m;
        }
    }
}
