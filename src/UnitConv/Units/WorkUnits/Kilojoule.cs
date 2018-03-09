using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.WorkUnits
{
    public class Kilojoule : WorkUnit
    {
        private Kilojoule()
        {

        }

        private static readonly Kilojoule _instance = new Kilojoule();

        public static Kilojoule GetInstance()
        {
            return _instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "千焦" },
                { Languages.English, "KJ" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1000m;
        }
    }
}
