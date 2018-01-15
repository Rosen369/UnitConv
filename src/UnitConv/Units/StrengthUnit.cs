using System;
using System.Collections.Generic;
using System.Text;
using UnitConv.Units;

namespace UnitConv
{
    public abstract class StrengthUnit : Unit
    {
        public static StrengthUnit Dyne
        {
            get
            {
                return Units.StrengthUnits.Dyne.GetInstance();
            }
        }

        public static StrengthUnit GramForce
        {
            get
            {
                return Units.StrengthUnits.GramForce.GetInstance();
            }
        }

        public static StrengthUnit KilogramForce
        {
            get
            {
                return Units.StrengthUnits.KilogramForce.GetInstance();
            }
        }

        public static StrengthUnit KiloNewton
        {
            get
            {
                return Units.StrengthUnits.KiloNewton.GetInstance();
            }
        }

        public static StrengthUnit KilopoundForce
        {
            get
            {
                return Units.StrengthUnits.KilopoundForce.GetInstance();
            }
        }

        public static StrengthUnit Newton
        {
            get
            {
                return Units.StrengthUnits.Newton.GetInstance();
            }
        }

        public static StrengthUnit PoundForce
        {
            get
            {
                return Units.StrengthUnits.PoundForce.GetInstance();
            }
        }

        public static StrengthUnit TonneForce
        {
            get
            {
                return Units.StrengthUnits.TonneForce.GetInstance();
            }
        }
    }
}
