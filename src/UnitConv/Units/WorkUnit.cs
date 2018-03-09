using System;
using System.Collections.Generic;
using System.Text;
using UnitConv.Units;

namespace UnitConv
{
    public abstract class WorkUnit : Unit
    {
        public static WorkUnit Joule
        {
            get
            {
                return Units.WorkUnits.Joule.GetInstance();
            }
        }

        public static WorkUnit BritishHorsepowerHour
        {
            get
            {
                return Units.WorkUnits.BritishHorsepowerHour.GetInstance();
            }
        }

        public static WorkUnit BritishThermalUnit
        {
            get
            {
                return Units.WorkUnits.BritishThermalUnit.GetInstance();
            }
        }

        public static WorkUnit Calorie
        {
            get
            {
                return Units.WorkUnits.Calorie.GetInstance();
            }
        }

        public static WorkUnit FootPound
        {
            get
            {
                return Units.WorkUnits.FootPound.GetInstance();
            }
        }

        public static WorkUnit Kilocalorie
        {
            get
            {
                return Units.WorkUnits.Kilocalorie.GetInstance();
            }
        }

        public static WorkUnit KilogramMeter
        {
            get
            {
                return Units.WorkUnits.KilogramMeter.GetInstance();
            }
        }

        public static WorkUnit Kilojoule
        {
            get
            {
                return Units.WorkUnits.Kilojoule.GetInstance();
            }
        }

        public static WorkUnit KilowattHour
        {
            get
            {
                return Units.WorkUnits.KilowattHour.GetInstance();
            }
        }

        public static WorkUnit MetricHorsepowerHour
        {
            get
            {
                return Units.WorkUnits.MetricHorsepowerHour.GetInstance();
            }
        }
    }
}
