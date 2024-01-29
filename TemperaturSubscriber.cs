using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

public class TemperatureSubscriber
{
    private readonly TemperatureHandler temperatureHandler;

    public TemperatureSubscriber(TemperatureHandler temperatureHandler)
    {
        this.temperatureHandler = temperatureHandler;
        EventAggregator.Instance.Events.Subscribe<double>(temperatureHandler.HandleTemperatureEvent);
    }
}
