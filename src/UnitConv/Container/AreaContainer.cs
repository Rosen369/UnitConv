using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Container
{
    internal sealed class AreaContainer : ContainerBase<AreaUnit>
    {
        private AreaContainer()
        {

        }

        private static AreaContainer _instance = new AreaContainer();

        public static AreaContainer GetInstance()
        {
            return _instance;
        }
    }
}
