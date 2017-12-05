using System;
using System.Collections.Generic;
using System.Text;
using UnitConv.Units.LengthUnit;

namespace UnitConv
{
    internal interface ILanguageDisplayer
    {
        string GetLength(LengthUnit type);
    }
}
