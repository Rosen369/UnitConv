using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Extension
{
    public static class DensityExtension
    {
        public static Density ToGramPerCubicCentimeter(this Density density)
        {
            return density.ConvertValue(DensityUnit.GramPerCubicCentimeter);
        }

        public static Density ToGramPerCubicDecimeter(this Density density)
        {
            return density.ConvertValue(DensityUnit.GramPerCubicDecimeter);
        }

        public static Density ToGramPerCubicMeter(this Density density)
        {
            return density.ConvertValue(DensityUnit.GramPerCubicMeter);
        }

        public static Density ToKilogramPerCubicCentimeter(this Density density)
        {
            return density.ConvertValue(DensityUnit.KilogramPerCubicCentimeter);
        }

        public static Density ToKilogramPerCubicDecimeter(this Density density)
        {
            return density.ConvertValue(DensityUnit.KilogramPerCubicDecimeter);
        }

        public static Density ToKilogramPerCubicMeter(this Density density)
        {
            return density.ConvertValue(DensityUnit.KilogramPerCubicMeter);
        }
    }
}
