namespace UnitConv
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal partial class ConvertRateContainer
    {
        private IDictionary<ValueTuple<LengthType, LengthType>, float> LengthRateDic { get; set; }

        private void InitLengthRate()
        {
            LengthRateDic = new Dictionary<ValueTuple<LengthType, LengthType>, float>();
            LengthRateDic.Add((LengthType.Meter, LengthType.Mile), 1.1f);
        }
    }
}
