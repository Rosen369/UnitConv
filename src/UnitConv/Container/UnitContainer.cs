using System;
using System.Collections.Generic;
using System.Text;
using UnitConv.Units;

namespace UnitConv.Container
{
    /// <summary>
    /// container of all units
    /// </summary>
    internal class UnitContainer
    {
        private IList<IDictionary<string, Unit>> GetAllUnits()
        {
            throw new NotImplementedException();
        }

        public static T TryGetUnit<T>(string unit)
        {
            throw new NotImplementedException();
        }
    }
}
