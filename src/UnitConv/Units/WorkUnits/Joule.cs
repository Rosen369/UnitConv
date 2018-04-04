using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.WorkUnits
{
    public class Joule : WorkUnit
    {
        private class Nested
        {
            internal static readonly Joule Instance = new Joule();
        }

        private Joule()
        {

        }

        public static Joule GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "焦耳" },
                { Languages.English, "J" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1m;
        }
    }
}
