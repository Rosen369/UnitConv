using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.WorkUnits
{
    public class FootPound : WorkUnit
    {
        private FootPound()
        {

        }

        private static readonly FootPound _instance = new FootPound();

        public static FootPound GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "英尺·磅" },
                { Languages.English, "ft·lb" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1.3557483731m;
        }
    }
}
