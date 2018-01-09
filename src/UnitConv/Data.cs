using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv
{
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
            if (toUnit == this.Unit) new Data(this.Value, toUnit);
            var basicRate = this.Unit.GetRate();
            var rate = toUnit.GetRate();
            var targetValue = this.Value * basicRate / rate;
            return new Data(targetValue, toUnit);
        }
    }
}
