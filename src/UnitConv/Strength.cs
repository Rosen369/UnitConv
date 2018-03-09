using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv
{
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
            if (toUnit == this.Unit) new Strength(this.Value, toUnit);
            var basicRate = this.Unit.GetRate();
            var rate = toUnit.GetRate();
            var targetValue = this.Value * basicRate / rate;
            return new Strength(targetValue, toUnit);
        }
    }
}
