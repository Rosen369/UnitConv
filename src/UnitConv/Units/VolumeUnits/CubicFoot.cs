using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.VolumeUnits
{
    public class CubicFoot : VolumeUnit
    {
        private CubicFoot()
        {

        }

        private static readonly CubicFoot _instance = new CubicFoot();

        public static CubicFoot GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "立方英尺" },
                { Languages.English, "cu.ft." }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.0283168m;
        }
    }
}
