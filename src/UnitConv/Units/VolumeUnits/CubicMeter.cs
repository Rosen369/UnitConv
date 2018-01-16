using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.VolumeUnits
{
    public class CubicMeter : VolumeUnit
    {
        private CubicMeter()
        {

        }

        private static readonly CubicMeter _instance = new CubicMeter();

        public static CubicMeter GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "立方米" },
                { Languages.English, "m³" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1m;
        }
    }
}
