using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.VolumeUnits
{
    public class USGallon : VolumeUnit
    {
        private USGallon()
        {

        }

        private static readonly USGallon _instance = new USGallon();

        public static USGallon GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "美制加仑" },
                { Languages.English, "us gal" }
            };
        }

        protected override void InitRate()
        {
            _rate = 231m * 0.016387064m / 1000m;
        }
    }
}
