namespace UnitConv
{
    using System;
    using System.Collections.Generic;
    using System.Text;

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
                { Languages.English, new EnDisplayer() }
            };
        }

        private static UnitDisplayer Instance { get; set; }

        private IDictionary<Languages, LanguageDisplayer> LanguageContainer { get; set; }

        public static string GetDisplay(Languages language, LengthType type)
        {
            var container = Instance.LanguageContainer[language];
            var display = container.GetLength(type);
            return display;
        }
    }
}
