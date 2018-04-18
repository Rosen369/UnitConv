using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.WorkUnits
{
    public class BritishHorsepowerHour : WorkUnit
    {
        private class Nested
        {
            internal static readonly BritishHorsepowerHour Instance = new BritishHorsepowerHour();
        }

        private BritishHorsepowerHour()
        {

        }

        public static BritishHorsepowerHour GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "英制马力·时" },
                { Languages.English, "British horse power hour" },
                { Languages.Symbol, "hp·h" }
            };
        }

        protected override void InitRate()
        {
            _rate = 745.699872m * 3600m;
        }
    }
}
