using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.LengthUnits
{
    public class Foot : LengthUnit
    {
        private Foot()
        {

        }

        private static readonly Foot _instance = new Foot();

        public static Foot GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "英尺" },
                { Languages.English, "ft" }
            };
        }

        protected override void InitRate()
        {
            _rate = 0.304794m;
        }
    }
}
