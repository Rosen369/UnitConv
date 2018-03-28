using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv
{
    /// <summary>
    /// quantity type of power
    /// </summary>
    public class Power : Quantity<PowerUnit, Power>
    {
        public Power(string quantity) : base(quantity)
        {
        }

        public Power(decimal value, PowerUnit unit) : base(value, unit)
        {
        }

        public Power(string value, string unit) : base(value, unit)
        {
        }

        public Power(decimal value, string unit) : base(value, unit)
        {
        }

        public Power(string value, PowerUnit unit) : base(value, unit)
        {
        }

        protected internal override Power ConvertValue(PowerUnit toUnit)
        {
            if (toUnit == this.Unit) new Power(this.Value, toUnit);
            var targetValue = this.CalculateConversion(this.Unit, toUnit);
            return new Power(targetValue, toUnit);
        }
    }
}
