using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units
{
    public interface IUnit
    {
        decimal Rate { get; }

        decimal Subtrahend { get; }

        string GetDisplay(Languages language);
    }
}
