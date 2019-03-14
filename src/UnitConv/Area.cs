using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv
{
    /// <summary>
    /// quantity type of area
    /// </summary>
    public class Area : Quantity<AreaUnit, Area>
    {
        public Area(decimal value, AreaUnit unit) : base(value, unit)
        {
        }

        public Area(string quantity) : base(quantity)
        {
        }

        public Area(string value, string unit) : base(value, unit)
        {
        }

        public Area(decimal value, string unit) : base(value, unit)
        {
        }

        public Area(string value, AreaUnit unit) : base(value, unit)
        {
        }

        protected internal override Area ConvertValue(AreaUnit toUnit)
        {
            if (toUnit == this.Unit) return new Area(this.Value, toUnit);
            var targetValue = this.CalculateConversion(this.Unit, toUnit);
            return new Area(targetValue, toUnit);
        }
    }
}
