using System;
using System.Collections.Generic;
using System.Text;
using UnitConv.Units;

namespace UnitConv
{
    public abstract class LengthUnit : Unit
    {
        public static LengthUnit Meter
        {
            get
            {
                return Units.LengthUnits.Meter.GetInstance();
            }
        }

        public static LengthUnit Mile
        {
            get
            {
                return Units.LengthUnits.Mile.GetInstance();
            }
        }

        public static LengthUnit Kilometer
        {
            get
            {
                return Units.LengthUnits.Kilometer.GetInstance();
            }
        }

        public static LengthUnit Centimeter
        {
            get
            {
                return Units.LengthUnits.Centimeter.GetInstance();
            }
        }

        public static LengthUnit Decimeter
        {
            get
            {
                return Units.LengthUnits.Decimeter.GetInstance();
            }
        }

        public static LengthUnit Millimeter
        {
            get
            {
                return Units.LengthUnits.Millimeter.GetInstance();
            }
        }

        public static LengthUnit Micrometer
        {
            get
            {
                return Units.LengthUnits.Micrometer.GetInstance();
            }
        }

        public static LengthUnit Nanometer
        {
            get
            {
                return Units.LengthUnits.Nanometer.GetInstance();
            }
        }

        public static LengthUnit Picometer
        {
            get
            {
                return Units.LengthUnits.Picometer.GetInstance();
            }
        }

        public static LengthUnit LightYear
        {
            get
            {
                return Units.LengthUnits.LightYear.GetInstance();
            }
        }

        public static LengthUnit AstronomicalUnit
        {
            get
            {
                return Units.LengthUnits.AstronomicalUnit.GetInstance();
            }
        }

        public static LengthUnit Inch
        {
            get
            {
                return Units.LengthUnits.Inch.GetInstance();
            }
        }

        public static LengthUnit Foot
        {
            get
            {
                return Units.LengthUnits.Foot.GetInstance();
            }
        }

        public static LengthUnit Yard
        {
            get
            {
                return Units.LengthUnits.Yard.GetInstance();
            }
        }

        public static LengthUnit Fathom
        {
            get
            {
                return Units.LengthUnits.Fathom.GetInstance();
            }
        }

        public static LengthUnit Furlong
        {
            get
            {
                return Units.LengthUnits.Furlong.GetInstance();
            }
        }

        public static LengthUnit NauticalMile
        {
            get
            {
                return Units.LengthUnits.NauticalMile.GetInstance();
            }
        }
    }
}
