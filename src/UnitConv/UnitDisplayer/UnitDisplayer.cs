using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv
{
    internal class UnitDisplayer
    {
        static UnitDisplayer()
        {
            Instance = new UnitDisplayer();
        }

        private UnitDisplayer()
        {
            LanguageContainer = new Dictionary<Languages, LanguageDisplayer>
            {
                { Languages.English, new EnDisplayer() },
                { Languages.ChineseSimplify, new ChsDisplayer() }
            };
        }

        private static UnitDisplayer Instance { get; set; }

        private IDictionary<Languages, LanguageDisplayer> LanguageContainer { get; set; }

        public static string GetDisplay(Languages language, LengthUnit unit)
        {
            var container = Instance.LanguageContainer[language];
            var display = container.GetLength(unit);
            return display;
        }
    }
}
