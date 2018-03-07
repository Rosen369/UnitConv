using System;
using System.Collections.Generic;
using System.Text;
using UnitConv.Units;

namespace UnitConv
{
    public abstract class WorkUnit : Unit
    {
        public static WorkUnit Joule
        {
            get
            {
                return Units.WorkUnits.Joule.GetInstance();
            }
        }
    }
}
