using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv
{
    public interface IArea
    {
        decimal Value { get; }

        AreaUnit Unit { get; }

        IArea ToSquareMeter();

        IArea ToSquareDeciMeter();

        IArea ToSquareCentimeter();

        IArea ToSquareMillimeter();

        IArea ToAre();

        IArea ToSquareKilometer();

        IArea ToHectare();

        IArea ToAcre();

        IArea ToSquareMile();

        IArea ToSquareYard();

        IArea ToSquareFoot();

        IArea ToSquareInch();
    }
}
