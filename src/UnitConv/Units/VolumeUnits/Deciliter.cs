using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.VolumeUnits
{
    public class Deciliter : VolumeUnit
    {
        private Deciliter()
        {

        }

        private static Deciliter _instance = new Deciliter();

        public static Deciliter GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "分升" },
                { Languages.English, "dl" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.0001m;
        }
    }
}
