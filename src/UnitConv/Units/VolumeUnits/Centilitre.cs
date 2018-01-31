using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.VolumeUnits
{
    public class Centilitre : VolumeUnit
    {
        private Centilitre()
        {

        }

        private static readonly Centilitre _instance = new Centilitre();

        public static Centilitre GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "厘升" },
                { Languages.English, "cl" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.00001m;
        }
    }
}
