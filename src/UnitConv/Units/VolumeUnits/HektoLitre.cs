using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.VolumeUnits
{
    public class HektoLitre : VolumeUnit
    {
        private HektoLitre()
        {

        }

        private static readonly HektoLitre _instance = new HektoLitre();

        public static HektoLitre GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "百升" },
                { Languages.English, "hl" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.1m;
        }
    }
}
