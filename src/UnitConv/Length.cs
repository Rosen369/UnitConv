using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv
{
    /// <summary>
    /// quantity type of length
    /// </summary>
    public class Length : Quantity<LengthUnit, Length>
    {
        public Length(decimal value, LengthUnit unit) : base(value, unit)
        {
        }

        public Length(string quantity) : base(quantity)
        {
        }

        public Length(string value, string unit) : base(value, unit)
        {
        }

        public Length(decimal value, string unit) : base(value, unit)
        {
        }

        public Length(string value, LengthUnit unit) : base(value, unit)
        {
        }

        protected internal override Length ConvertValue(LengthUnit toUnit)
        {
            if (toUnit == this.Unit) new Length(this.Value, toUnit);
            var basicRate = this.Unit.GetRate();
            var rate = toUnit.GetRate();
            var targetValue = this.Value * basicRate / rate;
            return new Length(targetValue, toUnit);
        }
    }
}
