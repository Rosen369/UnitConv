using System;
using System.Collections.Generic;
using System.Text;
using UnitConv.Units;

namespace UnitConv
{
    public abstract class PressureUnit : Unit
    {
        public static PressureUnit Atmosphere
        {
            get
            {
                return Units.PressureUnits.Atmosphere.GetInstance();
            }
        }

        public static PressureUnit Bar
        {
            get
            {
                return Units.PressureUnits.Bar.GetInstance();
            }
        }

        public static PressureUnit Hectopascal
        {
            get
            {
                return Units.PressureUnits.Hectopascal.GetInstance();
            }
        }

        public static PressureUnit InchOfMercury
        {
            get
            {
                return Units.PressureUnits.InchOfMercury.GetInstance();
            }
        }

        public static PressureUnit Kilopascal
        {
            get
            {
                return Units.PressureUnits.Kilopascal.GetInstance();
            }
        }

        public static PressureUnit Megapascal
        {
            get
            {
                return Units.PressureUnits.Megapascal.GetInstance();
            }
        }

        public static PressureUnit Millibar
        {
            get
            {
                return Units.PressureUnits.Millibar.GetInstance();
            }
        }

        public static PressureUnit MillimeterOfMercury
        {
            get
            {
                return Units.PressureUnits.MillimeterOfMercury.GetInstance();
            }
        }

        public static PressureUnit NewtonPerSquareMeter
        {
            get
            {
                return Units.PressureUnits.NewtonPerSquareMeter.GetInstance();
            }
        }

        public static PressureUnit Pascal
        {
            get
            {
                return Units.PressureUnits.Pascal.GetInstance();
            }
        }

        public static PressureUnit PoundPerSquareFoot
        {
            get
            {
                return Units.PressureUnits.PoundPerSquareFoot.GetInstance();
            }
        }

        public static PressureUnit PoundPerSquareInch
        {
            get
            {
                return Units.PressureUnits.PoundPerSquareInch.GetInstance();
            }
        }
    }
}
