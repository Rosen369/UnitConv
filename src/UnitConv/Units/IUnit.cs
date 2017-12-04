using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units
{
    public interface IUnit
    {
        decimal GetRate();

        string GetDisplay(Languages language);
    }
}
