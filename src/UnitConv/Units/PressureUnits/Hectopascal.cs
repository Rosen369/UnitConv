using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.PressureUnits
{
    public class Hectopascal : PressureUnit
    {
        private Hectopascal()
        {

        }

        private static readonly Hectopascal _instance = new Hectopascal();

        public static Hectopascal GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "百帕" },
                { Languages.English, "hPa" }
            };
        }

        protected override void InitRate()
        {
            _rate = 100m;
        }
    }
}
