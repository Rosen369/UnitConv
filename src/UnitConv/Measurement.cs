using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv
{
    public abstract class Measurement<TUnit, TChild>
    {
        public decimal Value { get; protected set; }

        public TUnit Unit { get; protected set; }

        protected internal abstract TChild ConvertValue(TUnit toUnit);

        public override string ToString()
        {
            return this.ToString(Languages.English, 3);
        }

        public string ToString(int digits)
        {
            return this.ToString(Languages.English, digits);
        }

        public string ToString(Languages language)
        {
            return this.ToString(language, 3);
        }

        public abstract string ToString(Languages language, int digits);
        //public string ToString(Languages language, int digits)
        //{
        //    var value = Math.Round(this.Value, digits).ToString();
        //    return value + UnitDisplayer.GetDisplay(language, this.Unit);
        //}

        public override bool Equals(object obj)
        {
            if (!(obj is TChild)) return false;
            return this.Equals(obj as Measurement<TUnit, TChild>);
        }

        public bool Equals(Measurement<TUnit, TChild> measurement)
        {
            var result = measurement.ConvertValue(this.Unit) as Measurement<TUnit, TChild>;
            return result.Value == this.Value;
        }

        public override int GetHashCode()
        {
            var hashCode = 1582882615;
            hashCode = hashCode * -1521134295 + Value.GetHashCode();
            hashCode = hashCode * -1521134295 + Unit.GetHashCode();
            return hashCode;
        }
    }
}
