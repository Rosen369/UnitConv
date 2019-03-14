using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv
{
    /// <summary>
    /// quantity type of temperature
    /// </summary>
    public class Temperature : Quantity<TemperatureUnit, Temperature>
    {
        public Temperature(string quantity) : base(quantity)
        {
        }

        public Temperature(decimal value, TemperatureUnit unit) : base(value, unit)
        {
        }

        public Temperature(string value, string unit) : base(value, unit)
        {
        }

        public Temperature(decimal value, string unit) : base(value, unit)
        {
        }

        public Temperature(string value, TemperatureUnit unit) : base(value, unit)
        {
        }

        protected internal override Temperature ConvertValue(TemperatureUnit toUnit)
        {
            if (toUnit == this.Unit) return new Temperature(this.Value, toUnit);
            var targetValue = this.CalculateConversion(this.Unit, toUnit);
            return new Temperature(targetValue, toUnit);
        }
    }
}
