using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.LengthUnits
{
    public class Inch : LengthUnit
    {
        private class Nested
        {
            internal static readonly Inch Instance = new Inch();
        }

        private Inch()
        {

        }

        public static Inch GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "英寸" },
                { Languages.English, "inch" },
                { Languages.Symbol, "in" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.304794m / 12m;
        }
    }
}
