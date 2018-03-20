using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Container
{
    internal sealed class LengthContainer : ContainerBase<LengthUnit>
    {
        private LengthContainer()
        {

        }

        private static LengthContainer _instance = new LengthContainer();

        public static LengthContainer GetInstance()
        {
            return _instance;
        }
    }
}
