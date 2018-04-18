using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.VolumeUnits
{
    public class CubicYard : VolumeUnit
    {
        private class Nested
        {
            internal static readonly CubicYard Instance = new CubicYard();
        }

        private CubicYard()
        {

        }

        public static CubicYard GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "立方码" },
                { Languages.English, "cubic yard" },
                { Languages.Symbol, "cu.yd." }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.0283168m * 27m;
        }
    }
}
