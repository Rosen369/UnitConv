using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv
{
    /// <summary>
    /// settings of unit convision
    /// </summary>
    public static class UnitConvSettings
    {
        private static Languages _defaultLanguage = Languages.English;

        private static int _defaultDigits = 3;

        /// <summary>
        /// default tostring language is english
        /// set this property to change default language
        /// </summary>
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

        /// <summary>
        /// default round decimal digits is 3
        /// set this property to change default digits
        /// </summary>
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
