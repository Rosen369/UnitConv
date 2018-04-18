using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.LengthUnits
{
    public class Furlong : LengthUnit
    {
        private class Nested
        {
            internal static readonly Furlong Instance = new Furlong();
        }

        private Furlong()
        {

        }

        public static Furlong GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "弗隆" },
                { Languages.English, "furlong" },
                { Languages.Symbol, "fur" }
            };
        }

        protected override void InitRate()
        {
            _rate = 201.168m;
        }
    }
}
