using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.LengthUnits
{
    public class Fathom : LengthUnit
    {
        private class Nested
        {
            internal static readonly Fathom Instance = new Fathom();
        }

        private Fathom()
        {

        }

        public static Fathom GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "英寻" },
                { Languages.English, "fm" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1.8288m;
        }
    }
}
