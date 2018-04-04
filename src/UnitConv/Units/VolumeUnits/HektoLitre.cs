using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.VolumeUnits
{
    public class HektoLitre : VolumeUnit
    {
        private class Nested
        {
            internal static readonly HektoLitre Instance = new HektoLitre();
        }

        private HektoLitre()
        {

        }

        public static HektoLitre GetInstance()
        {
            return Nested.Instance;
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
