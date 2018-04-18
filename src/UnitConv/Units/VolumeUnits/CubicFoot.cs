using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.VolumeUnits
{
    public class CubicFoot : VolumeUnit
    {
        private class Nested
        {
            internal static readonly CubicFoot Instance = new CubicFoot();
        }

        private CubicFoot()
        {

        }

        public static CubicFoot GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "立方英尺" },
                { Languages.English, "cubic foot" },
                { Languages.Symbol, "cu.ft." }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.0283168m;
        }
    }
}
