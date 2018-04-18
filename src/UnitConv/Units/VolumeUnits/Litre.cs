using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.VolumeUnits
{
    public class Litre : VolumeUnit
    {
        private class Nested
        {
            internal static readonly Litre Instance = new Litre();
        }

        private Litre()
        {

        }

        public static Litre GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "升" },
                { Languages.English, "litre" },
                { Languages.Symbol, "l" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.001m;
        }
    }
}
