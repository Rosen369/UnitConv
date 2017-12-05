using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units.LengthUnit
{
    public abstract class LengthUnit : Unit
    {
        public static LengthUnit Meter
        {
            get
            {
                return Units.LengthUnit.Meter.GetInstance();
            }
        }

        public static LengthUnit Mile
        {
            get
            {
                return Units.LengthUnit.Mile.GetInstance();
            }
        }

        public static LengthUnit Kilometer
        {
            get
            {
                return Units.LengthUnit.Kilometer.GetInstance();
            }
        }

        public static LengthUnit Centimeter
        {
            get
            {
                return Units.LengthUnit.Centimeter.GetInstance();
            }
        }

        public static LengthUnit Decimeter
        {
            get
            {
                return Units.LengthUnit.Decimeter.GetInstance();
            }
        }

        public static LengthUnit Millimeter
        {
            get
            {
                return Units.LengthUnit.Millimeter.GetInstance();
            }
        }

        public static LengthUnit Micrometer
        {
            get
            {
                return Units.LengthUnit.Micrometer.GetInstance();
            }
        }

        public static LengthUnit Nanometer
        {
            get
            {
                return Units.LengthUnit.Nanometer.GetInstance();
            }
        }

        public static LengthUnit Picometer
        {
            get
            {
                return Units.LengthUnit.Picometer.GetInstance();
            }
        }

        public static LengthUnit LightYear
        {
            get
            {
                return Units.LengthUnit.LightYear.GetInstance();
            }
        }

        public static LengthUnit AstronomicalUnit
        {
            get
            {
                return Units.LengthUnit.AstronomicalUnit.GetInstance();
            }
        }

        public static LengthUnit Inch
        {
            get
            {
                return Units.LengthUnit.Inch.GetInstance();
            }
        }

        public static LengthUnit Foot
        {
            get
            {
                return Units.LengthUnit.Foot.GetInstance();
            }
        }

        public static LengthUnit Yard
        {
            get
            {
                return Units.LengthUnit.Yard.GetInstance();
            }
        }

        public static LengthUnit Fathom
        {
            get
            {
                return Units.LengthUnit.Fathom.GetInstance();
            }
        }

        public static LengthUnit Furlong
        {
            get
            {
                return Units.LengthUnit.Furlong.GetInstance();
            }
        }

        public static LengthUnit NauticalMile
        {
            get
            {
                return Units.LengthUnit.NauticalMile.GetInstance();
            }
        }
    }
}
