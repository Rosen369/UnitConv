using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv
{
    public interface ILength
    {
        decimal Value { get; }

        LengthUnit Unit { get; }

        ILength ToMile();

        ILength ToMeter();

        ILength ToKilometer();

        ILength ToCentimeter();

        ILength ToDecimeter();

        ILength ToMillimeter();

        ILength ToMicrometer();

        ILength ToNanometer();

        ILength ToPicometer();

        ILength ToLightYear();

        ILength ToAstronomicalUnit();

        ILength ToInch();

        ILength ToFoot();

        ILength ToYard();

        ILength ToFathom();

        ILength ToFurlong();

        ILength ToNauticalMile();
    }
}
