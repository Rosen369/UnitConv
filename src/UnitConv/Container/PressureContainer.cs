using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Container
{
    internal sealed class PressureContainer : ContainerBase<PressureUnit>
    {
        private PressureContainer()
        {

        }

        private static PressureContainer _instance = new PressureContainer();

        public static PressureContainer GetInstance()
        {
            return _instance;
        }
    }
}
