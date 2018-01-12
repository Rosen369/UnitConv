using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.PressureUnits
{
    public class Atmosphere : PressureUnit
    {
        private Atmosphere()
        {

        }

        private static readonly Atmosphere _instance = new Atmosphere();

        public static Atmosphere GetInstance()
        {
            return _instance;
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
