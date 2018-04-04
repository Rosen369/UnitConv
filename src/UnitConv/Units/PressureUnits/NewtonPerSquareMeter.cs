using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.PressureUnits
{
    public class NewtonPerSquareMeter : PressureUnit
    {
        private class Nested
        {
            internal static readonly NewtonPerSquareMeter Instance = new NewtonPerSquareMeter();
        }

        private NewtonPerSquareMeter()
        {

        }

        public static NewtonPerSquareMeter GetInstance()
        {
            return Nested.Instance;
        }

        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>
            {
                { Languages.Chinese, "牛顿/平方米" },
                { Languages.English, "N/m²" }
            };
        }

        protected override void InitRate()
        {
            _rate = 1m;
        }
    }
}
