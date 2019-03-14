using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv
{
    /// <summary>
    /// quantity type of data
    /// </summary>
    public class Data : Quantity<DataUnit, Data>
    {
        public Data(string quantity) : base(quantity)
        {
        }

        public Data(decimal value, DataUnit unit) : base(value, unit)
        {
        }

        public Data(string value, string unit) : base(value, unit)
        {
        }

        public Data(decimal value, string unit) : base(value, unit)
        {
        }

        public Data(string value, DataUnit unit) : base(value, unit)
        {
        }

        protected internal override Data ConvertValue(DataUnit toUnit)
        {
            if (toUnit == this.Unit) return new Data(this.Value, toUnit);
            var targetValue = this.CalculateConversion(this.Unit, toUnit);
            return new Data(targetValue, toUnit);
        }
    }
}
