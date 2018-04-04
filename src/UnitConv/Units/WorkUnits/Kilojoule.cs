using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.WorkUnits
{
    public class Kilojoule : WorkUnit
    {
        private class Nested
        {
            internal static readonly Kilojoule Instance = new Kilojoule();
        }

        private Kilojoule()
        {

        }

        public static Kilojoule GetInstance()
        {
            return Nested.Instance;
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
