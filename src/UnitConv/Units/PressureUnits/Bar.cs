using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.PressureUnits
{
    public class Bar : PressureUnit
    {
        private Bar()
        {

        }

        private static readonly Bar _instance = new Bar();

        public static Bar GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "巴" },
                { Languages.English, "bar" }
            };
        }

        protected override void InitRate()
        {
            _rate = 100000m;
        }
    }
}
