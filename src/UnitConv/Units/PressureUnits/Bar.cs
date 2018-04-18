using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.PressureUnits
{
    public class Bar : PressureUnit
    {
        private class Nested
        {
            internal static readonly Bar Instance = new Bar();
        }

        private Bar()
        {

        }

        public static Bar GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "巴" },
                { Languages.English, "bar" },
                { Languages.Symbol, "bar" }
            };
        }

        protected override void InitRate()
        {
            _rate = 100000m;
        }
    }
}
