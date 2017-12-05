using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv
{
    internal abstract class LanguageDisplayer : ILanguageDisplayer
    {
        public LanguageDisplayer()
        {
            this.InitLengthDisplay();
            this.InitAreaDisplay();
        }

        protected abstract void InitLengthDisplay();

        protected abstract void InitAreaDisplay();

        protected IDictionary<LengthUnit, string> LengthDic { get; set; }

        protected IDictionary<AreaUnit, string> AreaDic { get; set; }


        public virtual string GetLength(LengthUnit unit)
        {
            var display = string.Empty;
            var hasDisplay = LengthDic.TryGetValue(unit, out display);
            if (!hasDisplay) throw new Exception("dont have display of " + unit);
            return display;
        }

        public virtual string GetArea(AreaUnit unit)
        {
            var display = string.Empty;
            var hasDisplay = AreaDic.TryGetValue(unit, out display);
            if (!hasDisplay) throw new Exception("dont have display of " + unit);
            return display;
        }
    }
}
