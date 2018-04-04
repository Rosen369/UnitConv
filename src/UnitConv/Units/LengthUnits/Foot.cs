using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.LengthUnits
{
    public class Foot : LengthUnit
    {
        private class Nested
        {
            internal static readonly Foot Instance = new Foot();
        }

        private Foot()
        {

        }

        public static Foot GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "英尺" },
                { Languages.English, "ft" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.304794m;
        }
    }
}
