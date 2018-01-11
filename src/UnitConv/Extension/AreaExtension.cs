using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv
{
    public static class AreaExtension
    {
        public static Area ToAcre(this Area area)
        {
            return area.ConvertValue(AreaUnit.Acre);
        }

        public static Area ToAre(this Area area)
        {
            return area.ConvertValue(AreaUnit.Are);
        }

        public static Area ToHectare(this Area area)
        {
            return area.ConvertValue(AreaUnit.Hectare);
        }

        public static Area ToSquareCentimeter(this Area area)
        {
            return area.ConvertValue(AreaUnit.SquareCentimeter);
        }

        public static Area ToSquareDeciMeter(this Area area)
        {
            return area.ConvertValue(AreaUnit.SquareDeciMeter);
        }

        public static Area ToSquareFoot(this Area area)
        {
            return area.ConvertValue(AreaUnit.SquareFoot);
        }

        public static Area ToSquareInch(this Area area)
        {
            return area.ConvertValue(AreaUnit.SquareInch);
        }

        public static Area ToSquareKilometer(this Area area)
        {
            return area.ConvertValue(AreaUnit.SquareKilometer);
        }

        public static Area ToSquareMeter(this Area area)
        {
            return area.ConvertValue(AreaUnit.SquareMeter);
        }

        public static Area ToSquareMile(this Area area)
        {
            return area.ConvertValue(AreaUnit.SquareMile);
        }

        public static Area ToSquareMillimeter(this Area area)
        {
            return area.ConvertValue(AreaUnit.SquareMillimeter);
        }

        public static Area ToSquareYard(this Area area)
        {
            return area.ConvertValue(AreaUnit.SquareYard);
        }
    }
}
