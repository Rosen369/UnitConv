using System;
using System.Collections.Generic;
using System.Text;
using UnitConv.Units;

namespace UnitConv
{
    /// <summary>
    /// area unit container
    /// </summary>
    public abstract class AreaUnit : Unit
    {
        public static AreaUnit Acre
        {
            get
            {
                return Units.AreaUnits.Acre.GetInstance();
            }
        }

        public static AreaUnit Are
        {
            get
            {
                return Units.AreaUnits.Are.GetInstance();
            }
        }

        public static AreaUnit Hectare
        {
            get
            {
                return Units.AreaUnits.Hectare.GetInstance();
            }
        }

        public static AreaUnit SquareCentimeter
        {
            get
            {
                return Units.AreaUnits.SquareCentimeter.GetInstance();
            }
        }

        public static AreaUnit SquareDeciMeter
        {
            get
            {
                return Units.AreaUnits.SquareDecimeter.GetInstance();
            }
        }

        public static AreaUnit SquareFoot
        {
            get
            {
                return Units.AreaUnits.SquareFoot.GetInstance();
            }
        }

        public static AreaUnit SquareInch
        {
            get
            {
                return Units.AreaUnits.SquareInch.GetInstance();
            }
        }

        public static AreaUnit SquareKilometer
        {
            get
            {
                return Units.AreaUnits.SquareKilometer.GetInstance();
            }
        }

        public static AreaUnit SquareMeter
        {
            get
            {
                return Units.AreaUnits.SquareMeter.GetInstance();
            }
        }

        public static AreaUnit SquareMile
        {
            get
            {
                return Units.AreaUnits.SquareMile.GetInstance();
            }
        }

        public static AreaUnit SquareMillimeter
        {
            get
            {
                return Units.AreaUnits.SquareMillimeter.GetInstance();
            }
        }

        public static AreaUnit SquareYard
        {
            get
            {
                return Units.AreaUnits.SquareYard.GetInstance();
            }
        }
    }
}
