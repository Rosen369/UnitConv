using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Container
{
    internal sealed class WeightContainer : ContainerBase<WeightUnit>
    {
        private WeightContainer()
        {

        }

        private static WeightContainer _instance = new WeightContainer();

        public static WeightContainer GetInstance()
        {
            return _instance;
        }
    }
}
