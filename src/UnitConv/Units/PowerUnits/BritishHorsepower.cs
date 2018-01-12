using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.PowerUnits
{
    public class BritishHorsepower : PowerUnit
    {
        private BritishHorsepower()
        {

        }

        private static readonly BritishHorsepower _instance = new BritishHorsepower();

        public static BritishHorsepower GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "英制马力" },
                { Languages.English, "hp" }
            };
        }

        protected override void InitRate()
        {
            _rate = 745.699872m;
        }
    }
}
