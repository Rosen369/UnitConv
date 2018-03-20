using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Container
{
    internal sealed class WorkContainer : ContainerBase<WorkUnit>
    {
        private WorkContainer()
        {

        }

        private static WorkContainer _instance = new WorkContainer();

        public static WorkContainer GetInstance()
        {
            return _instance;
        }
    }
}
