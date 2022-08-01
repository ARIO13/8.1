using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MeasuringDevice
{
    public interface IMeasuringDevice
    {
        
        /// <summary>
        /// Convert the raw dsta collected by the measuring device
        //into a metric valu
        /// </summary>
        /// <returns> yhe latest measurement from the device converted to metric units</returns>

        decimal MetricValue();
        ///<summary>
         ///Convert the raw dsta collected by the measuring device
        ///into a imperial value
        /// </summary>
        decimal ImperialValue();
        ///<summary>
        ///starts a measuring device
        ///</summary>
        void StartCollecting();
        ///<summary>
        ///stop a measuring device
        ///</summary>
        void StopCollecting();
        /// <summary>
        /// enable access to the raw data from the device in whatever
        /// units are native to the device.
        /// </summary>
        /// <returns>the raw data from the device in native formdt</returns>
        int[] GetRawData();
    }
    // TODO: Implement the IMeasuringDevice interface.
    public enum Units
    {
        Metric, Imperial
    }
}
