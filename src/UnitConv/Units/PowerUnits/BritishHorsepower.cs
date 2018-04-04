using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.PowerUnits
{
    public class BritishHorsepower : PowerUnit
    {
        private class Nested
        {
            internal static readonly BritishHorsepower Instance = new BritishHorsepower();
        }

        private BritishHorsepower()
        {

        }

        public static BritishHorsepower GetInstance()
        {
            return Nested.Instance;
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
