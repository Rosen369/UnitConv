using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Container
{
    internal sealed class SpeedContainer : ContainerBase<SpeedUnit>
    {
        private SpeedContainer()
        {

        }

        private static SpeedContainer _instance = new SpeedContainer();

        public static SpeedContainer GetInstance()
        {
            return _instance;
        }
    }
}
