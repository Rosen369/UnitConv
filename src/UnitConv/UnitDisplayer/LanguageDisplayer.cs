namespace UnitConv
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class LanguageDisplayer : ILanguageDisplayer
    {
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
