using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Converter
{
    public class WorkConverter : ConverterBase<Work, WorkUnit>
    {
        private WorkConverter()
        {

        }

        private static WorkConverter _instance = new WorkConverter();

        public static WorkConverter GetInstance()
        {
            return _instance;
        }
    }
}
