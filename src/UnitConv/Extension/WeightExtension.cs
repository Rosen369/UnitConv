using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Extension
{
    public static class WeightExtension
    {
        public static Weight ToGram(this Weight weight)
        {
            return weight.ConvertValue(WeightUnit.Gram);
        }

        public static Weight ToKilogram(this Weight weight)
        {
            return weight.ConvertValue(WeightUnit.Kilogram);
        }

        public static Weight ToMicrogram(this Weight weight)
        {
            return weight.ConvertValue(WeightUnit.Microgram);
        }

        public static Weight ToMilligram(this Weight weight)
        {
            return weight.ConvertValue(WeightUnit.Milligram);
        }

        public static Weight ToOunce(this Weight weight)
        {
            return weight.ConvertValue(WeightUnit.Ounce);
        }

        public static Weight ToPound(this Weight weight)
        {
            return weight.ConvertValue(WeightUnit.Pound);
        }

        public static Weight ToQuintal(this Weight weight)
        {
            return weight.ConvertValue(WeightUnit.Quintal);
        }

        public static Weight ToTon(this Weight weight)
        {
            return weight.ConvertValue(WeightUnit.Ton);
        }
    }
}
