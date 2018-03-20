using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Container
{
    internal sealed class VolumeContainer : ContainerBase<VolumeUnit>
    {
        private VolumeContainer()
        {

        }

        private static VolumeContainer _instance = new VolumeContainer();

        public static VolumeContainer GetInstance()
        {
            return _instance;
        }
    }
}
