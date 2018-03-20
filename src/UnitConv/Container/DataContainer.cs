using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Container
{
    internal sealed class DataContainer : ContainerBase<DataUnit>
    {
        private DataContainer()
        {

        }

        private static DataContainer _instance = new DataContainer();

        public static DataContainer GetInstance()
        {
            return _instance;
        }
    }
}
