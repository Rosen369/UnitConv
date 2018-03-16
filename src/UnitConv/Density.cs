﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv
{
    public class Density : Quantity<DensityUnit, Density>
    {
        public Density(string quantity) : base(quantity)
        {
        }

        public Density(decimal value, DensityUnit unit) : base(value, unit)
        {
        }

        public Density(string value, string unit) : base(value, unit)
        {
        }

        public Density(decimal value, string unit) : base(value, unit)
        {
        }

        public Density(string value, DensityUnit unit) : base(value, unit)
        {
        }

        protected internal override Density ConvertValue(DensityUnit toUnit)
        {
            if (toUnit == this.Unit) new Density(this.Value, toUnit);
            var basicRate = this.Unit.GetRate();
            var rate = toUnit.GetRate();
            var targetValue = this.Value * basicRate / rate;
            return new Density(targetValue, toUnit);
        }
    }
}