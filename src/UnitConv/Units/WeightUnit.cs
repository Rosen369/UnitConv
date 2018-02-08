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
    }
}
