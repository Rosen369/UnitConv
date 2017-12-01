using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.LengthUnit
{
    public class Meter : LengthUnit
    {
        protected override void InitDisplay()
        {
            _display = new Dictionary<Languages, string>();
        }

        protected override void InitRate()
        {
            _rate = 1;
        }
    }
}
