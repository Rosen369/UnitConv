using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitConv.Units;

namespace UnitConv.Utils
{
    /// <summary>
    /// container of all units
    /// </summary>
    internal class UnitContainer
    {
        public static T TryGetUnit<T>(string unit) where T : Unit
        {
            var typeName = typeof(T).ToString();
            if (!_container.ContainsKey(typeName)) AddUnitType<T>();
            if (!_container.ContainsKey(typeName)) return null;
            var dic = _container[typeName];
            if (!dic.ContainsKey(unit)) return null;
            return dic[unit] as T;
        }

        private static void AddUnitType<T>() where T : Unit
        {
            var units = typeof(T).GetProperties().Select(e => e.GetValue(null) as T).ToList();
            var languages = (Languages[])Enum.GetValues(typeof(Languages));
            var dic = new Dictionary<string, Unit>();
            foreach (var language in languages)
            {
                foreach (var unit in units)
                {
                    dic.Add(unit.GetDisplay(language), unit);
                }
            }
            _container.Add(typeof(T).ToString(), dic);
        }

        private static IDictionary<string, IDictionary<string, Unit>> _container = new Dictionary<string, IDictionary<string, Unit>>();
    }
}
