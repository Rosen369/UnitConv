using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.VolumeUnits
{
    public class Microliter : VolumeUnit
    {
        private class Nested
        {
            internal static readonly Microliter Instance = new Microliter();
        }

        private Microliter()
        {

        }

        public static Microliter GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "微升" },
                { Languages.English, "microliter" },
                { Languages.Symbol, "ul" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.000000001m;
        }
    }
}
