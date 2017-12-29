using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units
{
    /// <summary>
    /// container of all units
    /// </summary>
    internal class UnitContainer
    {
        private static IDictionary<string, Unit> _unitDic;

        private static IList<LengthUnit> _lengthUnits;

        private static IList<AreaUnit> _areaUnits;

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

        public static IList<AreaUnit> AreaUnits
        {
            get
            {
                if (_areaUnits == null)
                {
                    InitAreaList();
                }
                return _areaUnits;
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

        private static void InitAreaList()
        {
            _areaUnits = new List<AreaUnit>
                    {
                        AreaUnit.Acre,
                        AreaUnit.Are,
                        AreaUnit.Hectare,
                        AreaUnit.SquareCentimeter,
                        AreaUnit.SquareDeciMeter,
                        AreaUnit.SquareFoot,
                        AreaUnit.SquareInch,
                        AreaUnit.SquareKilometer,
                        AreaUnit.SquareMeter,
                        AreaUnit.SquareMile,
                        AreaUnit.SquareMillimeter,
                        AreaUnit.SquareYard,
                    };
        }

        private static void InitUnitDic()
        {
            _unitDic = new Dictionary<string, Unit>();
            foreach (var unit in LengthUnits)
            {
                _unitDic.Add(unit.GetDisplay(Languages.English), unit);
                _unitDic.Add(unit.GetDisplay(Languages.Chinese), unit);
            }
            foreach (var unit in AreaUnits)
            {
                _unitDic.Add(unit.GetDisplay(Languages.English), unit);
                _unitDic.Add(unit.GetDisplay(Languages.Chinese), unit);
            }
        }
    }
}
