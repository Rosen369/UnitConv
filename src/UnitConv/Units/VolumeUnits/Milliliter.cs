using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.VolumeUnits
{
    public class Milliliter : VolumeUnit
    {
        private class Nested
        {
            internal static readonly Milliliter Instance = new Milliliter();
        }

        private Milliliter()
        {

        }

        public static Milliliter GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "毫升" },
                { Languages.English, "milliliter" },
                { Languages.Symbol, "ml" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.000001m;
        }
    }
}
