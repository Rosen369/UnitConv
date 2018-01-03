using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.DataUnits
{
    class Bit : DataUnit
    {
        private Bit()
        {

        }

        private static readonly Bit _instance = new Bit();

        public static Bit GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "比特" },
                { Languages.English, "bit" }
            };
        }

        protected override void InitRate()
        {
            _rate = 8m;
        }
    }
}
