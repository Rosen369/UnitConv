using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.VolumeUnits
{
    public class CubicYard : VolumeUnit
    {
        private CubicYard()
        {

        }

        private static readonly CubicYard _instance = new CubicYard();

        public static CubicYard GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "立方码" },
                { Languages.English, "cu.yd." }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.0283168m * 27m;
        }
    }
}
