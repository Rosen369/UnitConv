using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Extension
{
    public static class VolumeExtension
    {
        public static Volume ToCentilitre(this Volume volume)
        {
            return volume.ConvertValue(VolumeUnit.Centilitre);
        }

        public static Volume ToCubicCentimeter(this Volume volume)
        {
            return volume.ConvertValue(VolumeUnit.CubicCentimeter);
        }

        public static Volume ToCubicDecimeter(this Volume volume)
        {
            return volume.ConvertValue(VolumeUnit.CubicDecimeter);
        }

        public static Volume ToCubicFoot(this Volume volume)
        {
            return volume.ConvertValue(VolumeUnit.CubicFoot);
        }

        public static Volume ToCubicInch(this Volume volume)
        {
            return volume.ConvertValue(VolumeUnit.CubicInch);
        }

        public static Volume ToCubicMeter(this Volume volume)
        {
            return volume.ConvertValue(VolumeUnit.CubicMeter);
        }

        public static Volume ToCubicMillimeter(this Volume volume)
        {
            return volume.ConvertValue(VolumeUnit.CubicMillimeter);
        }

        public static Volume ToCubicYard(this Volume volume)
        {
            return volume.ConvertValue(VolumeUnit.CubicYard);
        }

        public static Volume ToDeciliter(this Volume volume)
        {
            return volume.ConvertValue(VolumeUnit.Deciliter);
        }

        public static Volume ToHektoLitre(this Volume volume)
        {
            return volume.ConvertValue(VolumeUnit.HektoLitre);
        }

        public static Volume ToLitre(this Volume volume)
        {
            return volume.ConvertValue(VolumeUnit.Litre);
        }

        public static Volume ToMicroliter(this Volume volume)
        {
            return volume.ConvertValue(VolumeUnit.Microliter);
        }

        public static Volume ToMilliliter(this Volume volume)
        {
            return volume.ConvertValue(VolumeUnit.Milliliter);
        }

        public static Volume ToUKGallon(this Volume volume)
        {
            return volume.ConvertValue(VolumeUnit.UKGallon);
        }

        public static Volume ToUSGallon(this Volume volume)
        {
            return volume.ConvertValue(VolumeUnit.USGallon);
        }
    }
}
