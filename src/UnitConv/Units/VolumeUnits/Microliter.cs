using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.VolumeUnits
{
    public class Microliter : VolumeUnit
    {
        private Microliter()
        {

        }

        private static readonly Microliter _instance = new Microliter();

        public static Microliter GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "微升" },
                { Languages.English, "ul" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.000000001m;
        }
    }
}
