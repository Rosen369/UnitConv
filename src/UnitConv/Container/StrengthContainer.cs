using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Container
{
    internal sealed class StrengthContainer : ContainerBase<StrengthUnit>
    {
        private StrengthContainer()
        {

        }

        private static StrengthContainer _instance = new StrengthContainer();

        public static StrengthContainer GetInstance()
        {
            return _instance;
        }
    }
}
