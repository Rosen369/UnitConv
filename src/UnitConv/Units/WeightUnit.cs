using System;
using System.Collections.Generic;
using System.Text;
using UnitConv.Units;

namespace UnitConv
{
    public abstract class WeightUnit : Unit
    {
        public static WeightUnit Kilogram
        {
            get
            {
                return Units.WeightUnits.Kilogram.GetInstance();
            }
        }

        public static WeightUnit Gram
        {
            get
            {
                return Units.WeightUnits.Gram.GetInstance();
            }
        }
        public static WeightUnit Microgram
        {
            get
            {
                return Units.WeightUnits.Microgram.GetInstance();
            }
        }
        public static WeightUnit Milligram
        {
            get
            {
                return Units.WeightUnits.Milligram.GetInstance();
            }
        }
        public static WeightUnit Ounce
        {
            get
            {
                return Units.WeightUnits.Ounce.GetInstance();
            }
        }
        public static WeightUnit Pound
        {
            get
            {
                return Units.WeightUnits.Pound.GetInstance();
            }
        }
        public static WeightUnit Quintal
        {
            get
            {
                return Units.WeightUnits.Quintal.GetInstance();
            }
        }
        public static WeightUnit Ton
        {
            get
            {
                return Units.WeightUnits.Ton.GetInstance();
            }
        }
    }
}
