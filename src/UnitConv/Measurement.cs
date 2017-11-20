using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv
{
    public abstract class Measurement
    {
        public override string ToString()
        {
            return this.ToString(Languages.English, 3);
        }

        public string ToString(int digits)
        {
            return this.ToString(Languages.English, digits);
        }

        public string ToString(Languages language)
        {
            return this.ToString(language, 3);
        }

        public abstract string ToString(Languages language, int digits);
    }
}
