using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.VolumeUnits
{
    public class CubicInch : VolumeUnit
    {
        private CubicInch()
        {

        }

        private static readonly CubicInch _instance = new CubicInch();

        public static CubicInch GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "立方英寸" },
                { Languages.English, "cu.in." }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.0283168m / 1728m;
        }
    }
}
