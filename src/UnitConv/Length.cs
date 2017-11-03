namespace UnitConv
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Length
    {
        public Length(float value, LengthType type)
        {
            this.RawValue = value;
            this.RawType = type;
        }

        private float RawValue { get; set; }

        private LengthType RawType { get; set; }
    }
}
