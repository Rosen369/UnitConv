using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.VolumeUnits
{
    public class UKGallon : VolumeUnit
    {
        private UKGallon()
        {

        }

        private static readonly UKGallon _instance = new UKGallon();

        public static UKGallon GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "英制加仑" },
                { Languages.English, "uk gal" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.00454609188m;
        }
    }
}
