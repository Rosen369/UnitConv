namespace UnitConv
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class UnitDisplayer
    {
        static UnitDisplayer()
        {
            Instance = new UnitDisplayer();
        }

        private UnitDisplayer()
        {
            LanguageContainer = new Dictionary<Languages, LanguageDisplayer>();
            LanguageContainer.Add(Languages.English, new EnDisplayer());
        }

        private static UnitDisplayer Instance { get; set; }

        private IDictionary<Languages, LanguageDisplayer> LanguageContainer { get; set; }

        public static string GetDisplay(Languages language, LengthType type)
        {
            var container = Instance.LanguageContainer[Languages.English];
            var display = container.GetLength(type);
            return display;
        }
    }
}
