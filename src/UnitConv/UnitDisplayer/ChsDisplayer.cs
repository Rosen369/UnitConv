namespace UnitConv
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class ChsDisplayer : LanguageDisplayer
    {
        protected override void InitLengthDisplay()
        {
            LengthDic = new Dictionary<LengthType, string>
            {
                { LengthType.Kilometer, "千米" },
                { LengthType.Meter, "米" },
                { LengthType.Decimeter, "分米" },
                { LengthType.Centimeter, "厘米" },
                { LengthType.Millimeter, "毫米" },
                { LengthType.Micrometer, "微米" },
                { LengthType.Nanometer, "纳米" },
                { LengthType.Picometer, "皮米" },
                { LengthType.LightYear, "光年" },
                { LengthType.AstronomicalUnit, "天文单位" },
                { LengthType.Mile, "英里" },
                { LengthType.Inch, "英寸" },
                { LengthType.Foot, "英尺" },
                { LengthType.Yard, "码" },
                { LengthType.Fathom, "英寻" },
                { LengthType.Furlong, "弗隆" },
                { LengthType.NauticalMile, "海里" },
            };
        }
    }
}
