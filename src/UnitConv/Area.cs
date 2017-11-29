using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv
{
    public class Area : IArea
    {
        public Area(decimal value, AreaUnit unit)
        {
            this.Value = value;
            this.Unit = unit;
        }

        public decimal Value { get; private set; }

        public AreaUnit Unit { get; private set; }

        internal Area ConvertValue(AreaUnit toUnit)
        {
            if (toUnit == this.Unit) return this;
            var basicRate = ConvertRateContainer.GetRate(this.Unit);
            var rate = ConvertRateContainer.GetRate(toUnit);
            var targetValue = Value * basicRate / rate;
            return new Area(targetValue, toUnit);
        }

        public IArea ToAcre()
        {
            return this.ConvertValue(AreaUnit.Acre);
        }

        public IArea ToAre()
        {
            return this.ConvertValue(AreaUnit.Are);
        }

        public IArea ToHectare()
        {
            return this.ConvertValue(AreaUnit.Hectare);
        }

        public IArea ToSquareCentimeter()
        {
            return this.ConvertValue(AreaUnit.SquareCentimeter);
        }

        public IArea ToSquareDeciMeter()
        {
            return this.ConvertValue(AreaUnit.SquareDeciMeter);
        }

        public IArea ToSquareFoot()
        {
            return this.ConvertValue(AreaUnit.SquareFoot);
        }

        public IArea ToSquareInch()
        {
            return this.ConvertValue(AreaUnit.SquareInch);
        }

        public IArea ToSquareKilometer()
        {
            return this.ConvertValue(AreaUnit.SquareKilometer);
        }

        public IArea ToSquareMeter()
        {
            return this.ConvertValue(AreaUnit.SquareMeter);
        }

        public IArea ToSquareMile()
        {
            return this.ConvertValue(AreaUnit.SquareMile);
        }

        public IArea ToSquareMillimeter()
        {
            return this.ConvertValue(AreaUnit.SquareMillimeter);
        }

        public IArea ToSquareYard()
        {
            return this.ConvertValue(AreaUnit.SquareYard);
        }

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
            return value + UnitDisplayer.GetDisplay(language, this.Unit);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Area)) return false;
            return this.Equals(obj as Area);
        }

        public bool Equals(Area length)
        {
            var value = length.ConvertValue(this.Unit).Value;
            return value == this.Value;
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
