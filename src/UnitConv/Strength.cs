using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv
{
    /// <summary>
    /// quantity type of strength
    /// </summary>
    public class Strength : Quantity<StrengthUnit, Strength>
    {
        public Strength(string quantity) : base(quantity)
        {
        }

        public Strength(decimal value, StrengthUnit unit) : base(value, unit)
        {
        }

        public Strength(string value, string unit) : base(value, unit)
        {
        }

        public Strength(decimal value, string unit) : base(value, unit)
        {
        }

        public Strength(string value, StrengthUnit unit) : base(value, unit)
        {
        }

        protected internal override Strength ConvertValue(StrengthUnit toUnit)
        {
            if (toUnit == this.Unit) return new Strength(this.Value, toUnit);
            var targetValue = this.CalculateConversion(this.Unit, toUnit);
            return new Strength(targetValue, toUnit);
        }
    }
}
