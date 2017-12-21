using System;
using System.Collections.Generic;
using System.Text;
using UnitConv.Units;

namespace UnitConv
{
    public abstract class Measurement
    {
        public decimal Value { get; protected set; }

        public Unit Unit { get; protected set; }

        protected internal abstract Measurement ConvertValue(Unit toUnit);

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

        public string ToString(Languages language, int digits)
        {
            var value = Math.Round(this.Value, digits).ToString();
            return value + this.Unit.GetDisplay(language);
        }

        //public override bool Equals(object obj)
        //{
        //    if (!(obj is Length)) return false;
        //    return this.Equals(obj as Length);
        //}

        //public bool Equals(Length length)
        //{
        //    var value = length.ConvertValue(this.Unit).Value;
        //    return value == this.Value;
        //}

        //public override int GetHashCode()
        //{
        //    var hashCode = 1582882615;
        //    hashCode = hashCode * -1521134295 + Value.GetHashCode();
        //    hashCode = hashCode * -1521134295 + Unit.GetHashCode();
        //    return hashCode;
        //}
    }
}
