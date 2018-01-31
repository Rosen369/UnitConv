using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.VolumeUnits
{
    public class Litre : VolumeUnit
    {
        private Litre()
        {

        }

        private static readonly Litre _instance = new Litre();

        public static Litre GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "升" },
                { Languages.English, "l" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.001m;
        }
    }
}
