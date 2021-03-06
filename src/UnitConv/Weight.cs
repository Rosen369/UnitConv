﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv
{
    /// <summary>
    /// quantity type of weight
    /// </summary>
    public class Weight : Quantity<WeightUnit, Weight>
    {
        public Weight(string quantity) : base(quantity)
        {
        }

        public Weight(decimal value, WeightUnit unit) : base(value, unit)
        {
        }

        public Weight(string value, string unit) : base(value, unit)
        {
        }

        public Weight(decimal value, string unit) : base(value, unit)
        {
        }

        public Weight(string value, WeightUnit unit) : base(value, unit)
        {
        }

        protected internal override Weight ConvertValue(WeightUnit toUnit)
        {
            if (toUnit == this.Unit) return new Weight(this.Value, toUnit);
            var targetValue = this.CalculateConversion(this.Unit, toUnit);
            return new Weight(targetValue, toUnit);
        }
    }
}
