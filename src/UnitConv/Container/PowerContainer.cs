using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Container
{
    internal sealed class PowerContainer : ContainerBase<PowerUnit>
    {
        private PowerContainer()
        {

        }

        private static PowerContainer _instance = new PowerContainer();

        public static PowerContainer GetInstance()
        {
            return _instance;
        }
    }
}
