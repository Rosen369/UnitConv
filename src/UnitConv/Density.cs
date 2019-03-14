using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv
{
    /// <summary>
    /// quantity type of density
    /// </summary>
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
            if (toUnit == this.Unit) return new Density(this.Value, toUnit);
            var targetValue = this.CalculateConversion(this.Unit, toUnit);
            return new Density(targetValue, toUnit);
        }
    }
}
