using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.VolumeUnits
{
    public class CubicMillimeter : VolumeUnit
    {
        private CubicMillimeter()
        {

        }

        private static readonly CubicMillimeter _instance = new CubicMillimeter();

        public static CubicMillimeter GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "立方毫米" },
                { Languages.English, "mm³" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.000000001m;
        }
    }
}
