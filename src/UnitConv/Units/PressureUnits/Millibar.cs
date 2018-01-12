using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.PressureUnits
{
    public class Millibar : PressureUnit
    {
        private Millibar()
        {

        }

        private static readonly Millibar _instance = new Millibar();

        public static Millibar GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "毫巴" },
                { Languages.English, "mbar" }
            };
        }

        protected override void InitRate()
        {
            _rate = 100m;
        }
    }
}
