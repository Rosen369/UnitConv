using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.VolumeUnits
{
    public class USGallon : VolumeUnit
    {
        private class Nested
        {
            internal static readonly USGallon Instance = new USGallon();
        }

        private USGallon()
        {

        }

        public static USGallon GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "美制加仑" },
                { Languages.English, "US gallon" },
                { Languages.Symbol, "US gal" }
            };
        }

        protected override void InitRate()
        {
            _rate = 231m * 0.016387064m / 1000m;
        }
    }
}
