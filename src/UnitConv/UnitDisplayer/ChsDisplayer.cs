using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv
{
    internal class ChsDisplayer : LanguageDisplayer
    {
        protected override void InitLengthDisplay()
        {
            LengthDic = new Dictionary<LengthUnit, string>
            {
                { LengthUnit.Kilometer, "千米" },
                { LengthUnit.Meter, "米" },
                { LengthUnit.Decimeter, "分米" },
                { LengthUnit.Centimeter, "厘米" },
                { LengthUnit.Millimeter, "毫米" },
                { LengthUnit.Micrometer, "微米" },
                { LengthUnit.Nanometer, "纳米" },
                { LengthUnit.Picometer, "皮米" },
                { LengthUnit.LightYear, "光年" },
                { LengthUnit.AstronomicalUnit, "天文单位" },
                { LengthUnit.Mile, "英里" },
                { LengthUnit.Inch, "英寸" },
                { LengthUnit.Foot, "英尺" },
                { LengthUnit.Yard, "码" },
                { LengthUnit.Fathom, "英寻" },
                { LengthUnit.Furlong, "弗隆" },
                { LengthUnit.NauticalMile, "海里" },
            };
        }
    }
}
