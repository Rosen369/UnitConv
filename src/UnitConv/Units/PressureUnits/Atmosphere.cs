using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.PressureUnits
{
    public class Atmosphere : PressureUnit
    {
        private class Nested
        {
            internal static readonly Atmosphere Instance = new Atmosphere();
        }

        private Atmosphere()
        {

        }

        public static Atmosphere GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "标准大气压" },
                { Languages.English, "atm" }
            };
        }

        protected override void InitRate()
        {
            _rate = 101325m;
        }
    }
}
