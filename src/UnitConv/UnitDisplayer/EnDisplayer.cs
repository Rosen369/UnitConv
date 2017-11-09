namespace UnitConv
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class EnDisplayer : LanguageDisplayer
    {
        public EnDisplayer()
        {
            this.InitLengthDisplay();
        }

        private void InitLengthDisplay()
        {
            LengthDic = new Dictionary<LengthType, string>();
            LengthDic.Add(LengthType.Kilometer, "km");
            LengthDic.Add(LengthType.Meter, "m");
            LengthDic.Add(LengthType.Mile, "mi");
        }
    }
}
