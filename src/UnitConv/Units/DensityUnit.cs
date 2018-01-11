using System;
using System.Collections.Generic;
using System.Text;
using UnitConv.Units;

namespace UnitConv
{
    public abstract class DensityUnit : Unit
    {
        public static DensityUnit GramPerCubicCentimeter
        {
            get
            {
                return Units.DensityUnits.GramPerCubicCentimeter.GetInstance();
            }
        }

        public static DensityUnit GramPerCubicDecimeter
        {
            get
            {
                return Units.DensityUnits.GramPerCubicDecimeter.GetInstance();
            }
        }

        public static DensityUnit GramPerCubicMeter
        {
            get
            {
                return Units.DensityUnits.GramPerCubicMeter.GetInstance();
            }
        }

        public static DensityUnit KilogramPerCubicCentimeter
        {
            get
            {
                return Units.DensityUnits.KilogramPerCubicCentimeter.GetInstance();
            }
        }

        public static DensityUnit KilogramPerCubicDecimeter
        {
            get
            {
                return Units.DensityUnits.KilogramPerCubicDecimeter.GetInstance();
            }
        }

        public static DensityUnit KilogramPerCubicMeter
        {
            get
            {
                return Units.DensityUnits.KilogramPerCubicMeter.GetInstance();
            }
        }
    }
}
