using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Extension
{
    public static class PressureExtension
    {
        public static Pressure ToAtmosphere(this Pressure pressure)
        {
            return pressure.ConvertValue(PressureUnit.Atmosphere);
        }

        public static Pressure ToBar(this Pressure pressure)
        {
            return pressure.ConvertValue(PressureUnit.Bar);
        }

        public static Pressure ToHectopascal(this Pressure pressure)
        {
            return pressure.ConvertValue(PressureUnit.Hectopascal);
        }

        public static Pressure ToInchOfMercury(this Pressure pressure)
        {
            return pressure.ConvertValue(PressureUnit.InchOfMercury);
        }

        public static Pressure ToKilopascal(this Pressure pressure)
        {
            return pressure.ConvertValue(PressureUnit.Kilopascal);
        }

        public static Pressure ToMegapascal(this Pressure pressure)
        {
            return pressure.ConvertValue(PressureUnit.Megapascal);
        }

        public static Pressure ToMillibar(this Pressure pressure)
        {
            return pressure.ConvertValue(PressureUnit.Millibar);
        }

        public static Pressure ToMillimeterOfMercury(this Pressure pressure)
        {
            return pressure.ConvertValue(PressureUnit.MillimeterOfMercury);
        }

        public static Pressure ToNewtonPerSquareMeter(this Pressure pressure)
        {
            return pressure.ConvertValue(PressureUnit.NewtonPerSquareMeter);
        }

        public static Pressure ToPascal(this Pressure pressure)
        {
            return pressure.ConvertValue(PressureUnit.Pascal);
        }

        public static Pressure ToPoundPerSquareFoot(this Pressure pressure)
        {
            return pressure.ConvertValue(PressureUnit.PoundPerSquareFoot);
        }

        public static Pressure ToPoundPerSquareInch(this Pressure pressure)
        {
            return pressure.ConvertValue(PressureUnit.PoundPerSquareInch);
        }
    }
}
