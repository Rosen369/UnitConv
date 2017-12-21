using System;
using System.Collections.Generic;
using System.Text;
using UnitConv.Units;

namespace UnitConv
{
    internal class UnitDisplayer
    {
        private UnitDisplayer()
        {
            _languageContainer = new Dictionary<Languages, LanguageDisplayer>
            {
                { Languages.English, new EnDisplayer() },
                { Languages.ChineseSimplify, new ChsDisplayer() }
            };
        }

        private static UnitDisplayer _instance = new UnitDisplayer();

        private IDictionary<Languages, LanguageDisplayer> _languageContainer;

        public static string GetDisplay(Languages language, LengthUnit unit)
        {
            var container = _instance._languageContainer[language];
            var display = container.GetLength(unit);
            return display;
        }

        public static string GetDisplay(Languages language, AreaUnit unit)
        {
            var container = _instance._languageContainer[language];
            var display = container.GetArea(unit);
            return display;
        }
    }
}
