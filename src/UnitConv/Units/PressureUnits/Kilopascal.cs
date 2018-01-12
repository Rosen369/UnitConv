using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.PressureUnits
{
    public class Kilopascal : PressureUnit
    {
        private Kilopascal()
        {

        }

        private static readonly Kilopascal _instance = new Kilopascal();

        public static Kilopascal GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "千帕" },
                { Languages.English, "kPa" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1000m;
        }
    }
}
