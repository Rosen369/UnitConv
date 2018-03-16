using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Extension
{
    public static class StrengthExtension
    {
        public static Strength ToDyne(this Strength strength)
        {
            return strength.ConvertValue(StrengthUnit.Dyne);
        }

        public static Strength ToGramForce(this Strength strength)
        {
            return strength.ConvertValue(StrengthUnit.GramForce);
        }

        public static Strength ToKilogramForce(this Strength strength)
        {
            return strength.ConvertValue(StrengthUnit.KilogramForce);
        }

        public static Strength ToKiloNewton(this Strength strength)
        {
            return strength.ConvertValue(StrengthUnit.KiloNewton);
        }

        public static Strength ToKilopoundForce(this Strength strength)
        {
            return strength.ConvertValue(StrengthUnit.KilopoundForce);
        }

        public static Strength ToNewton(this Strength strength)
        {
            return strength.ConvertValue(StrengthUnit.Newton);
        }

        public static Strength ToPoundForce(this Strength strength)
        {
            return strength.ConvertValue(StrengthUnit.PoundForce);
        }

        public static Strength ToTonneForce(this Strength strength)
        {
            return strength.ConvertValue(StrengthUnit.TonneForce);
        }
    }
}
