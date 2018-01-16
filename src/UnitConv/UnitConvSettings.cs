using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv
{
    public static class UnitConvSettings
    {
        private static Languages _defaultLanguage = Languages.English;

        private static int _defaultDigits = 3;

        public static Languages DefaultLanguage
        {
            get
            {
                return _defaultLanguage;
            }
            set
            {
                _defaultLanguage = value;
            }
        }

        public static int DefaultDigits
        {
            get
            {
                return _defaultDigits;
            }
            set
            {
                if (value > 0)
                {
                    _defaultDigits = value;
                }
            }
        }
    }
}
