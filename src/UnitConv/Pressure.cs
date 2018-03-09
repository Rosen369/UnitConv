using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv
{
    public class Pressure : Quantity<PressureUnit, Pressure>
    {
        public Pressure(string quantity) : base(quantity)
        {
        }

        public Pressure(decimal value, PressureUnit unit) : base(value, unit)
        {
        }

        public Pressure(string value, string unit) : base(value, unit)
        {
        }

        public Pressure(decimal value, string unit) : base(value, unit)
        {
        }

        public Pressure(string value, PressureUnit unit) : base(value, unit)
        {
        }

        protected internal override Pressure ConvertValue(PressureUnit toUnit)
        {
            if (toUnit == this.Unit) new Pressure(this.Value, toUnit);
            var basicRate = this.Unit.GetRate();
            var rate = toUnit.GetRate();
            var targetValue = this.Value * basicRate / rate;
            return new Pressure(targetValue, toUnit);
        }
    }
}
