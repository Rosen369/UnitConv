using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv
{
    public class Area : Quantity<AreaUnit, Area>
    {
        public Area(decimal value, AreaUnit unit) : base(value, unit)
        {

        }

        public Area(string area) : base(area)
        {

        }

        public Area(string value, string unit) : base(value, unit)
        {

        }

        protected internal override Area ConvertValue(AreaUnit toUnit)
        {
            if (toUnit == this.Unit) new Area(this.Value, toUnit); ;
            var basicRate = this.Unit.GetRate();
            var rate = toUnit.GetRate();
            var targetValue = this.Value * basicRate / rate;
            return new Area(targetValue, toUnit);
        }

        public Area ToAcre()
        {
            return this.ConvertValue(AreaUnit.Acre);
        }

        public Area ToAre()
        {
            return this.ConvertValue(AreaUnit.Are);
        }

        public Area ToHectare()
        {
            return this.ConvertValue(AreaUnit.Hectare);
        }

        public Area ToSquareCentimeter()
        {
            return this.ConvertValue(AreaUnit.SquareCentimeter);
        }

        public Area ToSquareDeciMeter()
        {
            return this.ConvertValue(AreaUnit.SquareDeciMeter);
        }

        public Area ToSquareFoot()
        {
            return this.ConvertValue(AreaUnit.SquareFoot);
        }

        public Area ToSquareInch()
        {
            return this.ConvertValue(AreaUnit.SquareInch);
        }

        public Area ToSquareKilometer()
        {
            return this.ConvertValue(AreaUnit.SquareKilometer);
        }

        public Area ToSquareMeter()
        {
            return this.ConvertValue(AreaUnit.SquareMeter);
        }

        public Area ToSquareMile()
        {
            return this.ConvertValue(AreaUnit.SquareMile);
        }

        public Area ToSquareMillimeter()
        {
            return this.ConvertValue(AreaUnit.SquareMillimeter);
        }

        public Area ToSquareYard()
        {
            return this.ConvertValue(AreaUnit.SquareYard);
        }
    }
}
