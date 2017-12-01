using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Units
{
    internal abstract class Unit : IUnit
    {
        private Unit()
        {
            this.InitRate();
            this.InitDisplay();
        }

        protected readonly decimal _rate;

        protected readonly IDictionary<Languages, string> _display;

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
    }
}
