using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Converter
{
    public class WorkConverter : ConverterBase<Work, WorkUnit>
    {
        private class Nested
        {
            internal static readonly WorkConverter Instance = new WorkConverter();
        }

        private WorkConverter()
        {

        }

        public static WorkConverter GetInstance()
        {
            return Nested.Instance;
        }
    }
}
