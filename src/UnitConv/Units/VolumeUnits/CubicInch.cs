using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.VolumeUnits
{
    public class CubicInch : VolumeUnit
    {
        private class Nested
        {
            internal static readonly CubicInch Instance = new CubicInch();
        }

        private CubicInch()
        {

        }

        public static CubicInch GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "立方英寸" },
                { Languages.English, "cubic inch" },
                { Languages.Symbol, "cu.in." }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.0283168m / 1728m;
        }
    }
}
