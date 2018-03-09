using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.WorkUnits
{
    public class BritishHorsepowerHour : WorkUnit
    {
        private BritishHorsepowerHour()
        {

        }

        private static readonly BritishHorsepowerHour _instance = new BritishHorsepowerHour();

        public static BritishHorsepowerHour GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "英制马力·时" },
                { Languages.English, "hp·h" }
            };
        }

        protected override void InitRate()
        {
            _rate = 745.699872m * 3600m;
        }
    }
}
