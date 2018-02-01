using System;
using System.Collections.Generic;
using System.Text;
using UnitConv.Units;

namespace UnitConv
{
    public abstract class VolumeUnit : Unit
    {
        public static VolumeUnit Centilitre
        {
            get
            {
                return Units.VolumeUnits.Centilitre.GetInstance();
            }
        }

        public static VolumeUnit CubicCentimeter
        {
            get
            {
                return Units.VolumeUnits.CubicCentimeter.GetInstance();
            }
        }

        public static VolumeUnit CubicDecimeter
        {
            get
            {
                return Units.VolumeUnits.CubicDecimeter.GetInstance();
            }
        }

        public static VolumeUnit CubicFoot
        {
            get
            {
                return Units.VolumeUnits.CubicFoot.GetInstance();
            }
        }

        public static VolumeUnit CubicInch
        {
            get
            {
                return Units.VolumeUnits.CubicInch.GetInstance();
            }
        }

        public static VolumeUnit CubicMeter
        {
            get
            {
                return Units.VolumeUnits.CubicMeter.GetInstance();
            }
        }

        public static VolumeUnit CubicMillimeter
        {
            get
            {
                return Units.VolumeUnits.CubicMillimeter.GetInstance();
            }
        }

        public static VolumeUnit CubicYard
        {
            get
            {
                return Units.VolumeUnits.CubicYard.GetInstance();
            }
        }

        public static VolumeUnit Deciliter
        {
            get
            {
                return Units.VolumeUnits.Deciliter.GetInstance();
            }
        }

        public static VolumeUnit HektoLitre
        {
            get
            {
                return Units.VolumeUnits.HektoLitre.GetInstance();
            }
        }

        public static VolumeUnit Litre
        {
            get
            {
                return Units.VolumeUnits.Litre.GetInstance();
            }
        }

        public static VolumeUnit Microliter
        {
            get
            {
                return Units.VolumeUnits.Microliter.GetInstance();
            }
        }

        public static VolumeUnit Milliliter
        {
            get
            {
                return Units.VolumeUnits.Milliliter.GetInstance();
            }
        }

        public static VolumeUnit UKGallon
        {
            get
            {
                return Units.VolumeUnits.UKGallon.GetInstance();
            }
        }

        public static VolumeUnit USGallon
        {
            get
            {
                return Units.VolumeUnits.USGallon.GetInstance();
            }
        }
    }
}
