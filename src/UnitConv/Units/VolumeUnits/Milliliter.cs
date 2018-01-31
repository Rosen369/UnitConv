using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.VolumeUnits
{
    public class Milliliter : VolumeUnit
    {
        private Milliliter()
        {

        }

        private static readonly Milliliter _instance = new Milliliter();

        public static Milliliter GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "毫升" },
                { Languages.English, "ml" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.000001m;
        }
    }
}
