using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv
{
    /// <summary>
    /// quantity type of work
    /// </summary>
    public class Work : Quantity<WorkUnit, Work>
    {
        public Work(string quantity) : base(quantity)
        {
        }

        public Work(decimal value, WorkUnit unit) : base(value, unit)
        {
        }

        public Work(string value, string unit) : base(value, unit)
        {
        }

        public Work(decimal value, string unit) : base(value, unit)
        {
        }

        public Work(string value, WorkUnit unit) : base(value, unit)
        {
        }

        protected internal override Work ConvertValue(WorkUnit toUnit)
        {
            if (toUnit == this.Unit) new Work(this.Value, toUnit);
            var basicRate = this.Unit.GetRate();
            var rate = toUnit.GetRate();
            var targetValue = this.Value * basicRate / rate;
            return new Work(targetValue, toUnit);
        }
    }
}
