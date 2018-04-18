using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.VolumeUnits
{
    public class UKGallon : VolumeUnit
    {
        private class Nested
        {
            internal static readonly UKGallon Instance = new UKGallon();
        }

        private UKGallon()
        {

        }

        public static UKGallon GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "英制加仑" },
                { Languages.English, "UK gallon" },
                { Languages.Symbol, "UK gal" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.00454609188m;
        }
    }
}
