using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.VolumeUnits
{
    public class Deciliter : VolumeUnit
    {
        private class Nested
        {
            internal static readonly Deciliter Instance = new Deciliter();
        }

        private Deciliter()
        {

        }

        public static Deciliter GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "分升" },
                { Languages.English, "dl" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.0001m;
        }
    }
}
