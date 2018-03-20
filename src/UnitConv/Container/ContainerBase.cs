using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitConv.Units;

namespace UnitConv.Container
{
    internal abstract class ContainerBase<T> where T : Unit
    {
        protected IDictionary<string, T> _units;

        public IDictionary<string, T> Units
        {
            get
            {
                if (_units == null)
                {
                    InitUnitList();
                }
                return _units;
            }
        }

        protected void InitUnitList()
        {
            var units = typeof(T).GetProperties().Select(e => e.GetValue(null) as T).ToList();
            var languages = (Languages[])Enum.GetValues(typeof(Languages));
            _units = new Dictionary<string, T>();
            foreach (var language in languages)
            {
                foreach (var unit in units)
                {
                    _units.Add(unit.GetDisplay(language), unit);
                }
            }
        }
    }
}
