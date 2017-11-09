namespace UnitConv
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal abstract class LanguageDisplayer : ILanguageDisplayer
    {
        public LanguageDisplayer()
        {
            this.InitLengthDisplay();
        }

        protected abstract void InitLengthDisplay();

        protected IDictionary<LengthType, string> LengthDic { get; set; }

        public virtual string GetLength(LengthType type)
        {
            var display = string.Empty;
            var hasDisplay = LengthDic.TryGetValue(type, out display);
            if (!hasDisplay)
            {
                throw new Exception("dont have display of " + type);
            }
            return display;
        }
    }
}
