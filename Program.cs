using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        // Initialize handlers
        TemperatureHandler temperatureHandler = new TemperatureHandler();
        DimensionHandler dimensionHandler = new DimensionHandler();
        DurationHandler durationHandler = new DurationHandler();
        SelfTestHandler selfTestHandler = new SelfTestHandler();

        // Initialize subscribers
        EventAggregator.Instance.Events.Subscribe<double>(temperatureHandler.HandleTemperatureEvent);
        EventAggregator.Instance.Events.Subscribe<double>(dimensionHandler.HandleDimensionEvent);
        EventAggregator.Instance.Events.Subscribe<int>(durationHandler.HandleDurationEvent);
        EventAggregator.Instance.Events.Subscribe<int>(selfTestHandler.HandleSelfTestEvent);

        // Publish events
        EventAggregator.Instance.Events.PublishEvent<double>(36);
        EventAggregator.Instance.Events.PublishEvent<double>(0.07);
        EventAggregator.Instance.Events.PublishEvent<int>(300);
        EventAggregator.Instance.Events.PublishEvent<int>(0x02);

    }
}