using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.VolumeUnits
{
    public class Centilitre : VolumeUnit
    {
        private class Nested
        {
            internal static readonly Centilitre Instance = new Centilitre();
        }

        private Centilitre()
        {

        }

        public static Centilitre GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "厘升" },
                { Languages.English, "centilitre" },
                { Languages.Symbol, "cl" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.00001m;
        }
    }
}
