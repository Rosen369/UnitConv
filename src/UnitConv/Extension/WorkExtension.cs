using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConv.Extension
{
    public static class WorkExtension
    {
        public static Work ToBit(this Work work)
        {
            return work.ConvertValue(WorkUnit.BritishHorsepowerHour);
        }

        public static Work ToBritishThermalUnit(this Work work)
        {
            return work.ConvertValue(WorkUnit.BritishThermalUnit);
        }

        public static Work ToCalorie(this Work work)
        {
            return work.ConvertValue(WorkUnit.Calorie);
        }

        public static Work ToFootPound(this Work work)
        {
            return work.ConvertValue(WorkUnit.FootPound);
        }

        public static Work ToJoule(this Work work)
        {
            return work.ConvertValue(WorkUnit.Joule);
        }

        public static Work ToKilocalorie(this Work work)
        {
            return work.ConvertValue(WorkUnit.Kilocalorie);
        }

        public static Work ToKilogramMeter(this Work work)
        {
            return work.ConvertValue(WorkUnit.KilogramMeter);
        }

        public static Work ToKilojoule(this Work work)
        {
            return work.ConvertValue(WorkUnit.Kilojoule);
        }

        public static Work ToKilowattHour(this Work work)
        {
            return work.ConvertValue(WorkUnit.KilowattHour);
        }

        public static Work ToMetricHorsepowerHour(this Work work)
        {
            return work.ConvertValue(WorkUnit.MetricHorsepowerHour);
        }
    }
}
