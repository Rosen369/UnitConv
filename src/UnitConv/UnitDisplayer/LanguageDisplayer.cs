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
        }

        protected abstract void InitLengthDisplay();

        protected IDictionary<LengthUnit, string> LengthDic { get; set; }

        public virtual string GetLength(LengthUnit unit)
        {
            var display = string.Empty;
            var hasDisplay = LengthDic.TryGetValue(unit, out display);
            if (!hasDisplay)
            {
                throw new Exception("dont have display of " + unit);
            }
            return display;
        }
    }
}
