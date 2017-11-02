using System;
using System.Collections.Generic;
using System.Text;

namespace NetMetrology
{
    interface IMetrologyValue
    {
        float Value { get; set; }

        IMetrologyUnit Unit { get; set; }
    }
}
