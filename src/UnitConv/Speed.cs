﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv
{
    /// <summary>
    /// quantity type of speed
    /// </summary>
    public class Speed : Quantity<SpeedUnit, Speed>
    {
        public Speed(string quantity) : base(quantity)
        {
        }

        public Speed(decimal value, SpeedUnit unit) : base(value, unit)
        {
        }

        public Speed(string value, string unit) : base(value, unit)
        {
        }

        public Speed(decimal value, string unit) : base(value, unit)
        {
        }

        public Speed(string value, SpeedUnit unit) : base(value, unit)
        {
        }

        protected internal override Speed ConvertValue(SpeedUnit toUnit)
        {
            if (toUnit == this.Unit) return new Speed(this.Value, toUnit);
            var targetValue = this.CalculateConversion(this.Unit, toUnit);
            return new Speed(targetValue, toUnit);
        }
    }
}
