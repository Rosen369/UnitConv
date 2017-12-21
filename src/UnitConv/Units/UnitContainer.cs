using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units
{
    internal class UnitContainer
    {
        private static IDictionary<string, Unit> _unitDic;

        private static IList<LengthUnit> _lengthUnits;

        internal static IDictionary<string, Unit> UnitDic
        {
            get
            {
                if (_unitDic == null)
                {
                    InitUnitDic();
                }
                return _unitDic;
            }
        }

        public static IList<LengthUnit> LengthUnits
        {
            get
            {
                if (_lengthUnits == null)
                {
                    InitLengthList();
                }
                return _lengthUnits;
            }
        }

        private static void InitLengthList()
        {
            _lengthUnits = new List<LengthUnit>
                    {
                        LengthUnit.AstronomicalUnit,
                        LengthUnit.Centimeter,
                        LengthUnit.Decimeter,
                        LengthUnit.Fathom,
                        LengthUnit.Foot,
                        LengthUnit.Furlong,
                        LengthUnit.Inch,
                        LengthUnit.Kilometer,
                        LengthUnit.LightYear,
                        LengthUnit.Meter,
                        LengthUnit.Micrometer,
                        LengthUnit.Mile,
                        LengthUnit.Millimeter,
                        LengthUnit.Nanometer,
                        LengthUnit.NauticalMile,
                        LengthUnit.Picometer,
                        LengthUnit.Yard,
                    };
        }

        private static void InitUnitDic()
        {
            _unitDic = new Dictionary<string, Unit>();
            foreach (var unit in LengthUnits)
            {
                _unitDic.Add(unit.GetDisplay(Languages.English), unit);
                _unitDic.Add(unit.GetDisplay(Languages.ChineseSimplify), unit);
            }
        }
    }
}
