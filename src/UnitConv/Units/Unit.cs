using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units
{
    public abstract class Unit : IUnit
    {
        protected Unit()
        {
            this.InitRate();
            this.InitDisplay();
        }

        protected decimal _rate;

        protected IDictionary<Languages, string> _display;

        private static IDictionary<string, Unit> _typeDictionary;

        internal static IDictionary<string, Unit> TypeDictionary
        {
            get
            {
                if (_typeDictionary == null)
                {
                    InitTypeDictionary();
                }
                return _typeDictionary;
            }
        }

        protected abstract void InitDisplay();

        protected abstract void InitRate();

        public string GetDisplay(Languages language)
        {
            if (_display == null) throw new Exception("display has not been initialized");
            if (!_display.ContainsKey(language)) throw new Exception("dont have display of language" + language.ToString());
            return _display[language];
        }

        public decimal GetRate()
        {
            if (_rate == 0) throw new Exception("rate has not been initialized");
            return _rate;
        }
        private static void InitTypeDictionary()
        {
            _typeDictionary = new Dictionary<string, Unit>();
            foreach (var unit in LengthUnit.LengthUnits)
            {
                _typeDictionary.Add(unit.GetDisplay(Languages.English), unit);
            }
        }
    }
}
