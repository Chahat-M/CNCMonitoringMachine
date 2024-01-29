using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

public class DurationSubscriber
{
    private readonly DurationHandler durationHandler;

    public DurationSubscriber(DurationHandler durationHandler)
    {
        this.durationHandler = durationHandler;
        EventAggregator.Instance.Events.Subscribe<int>(durationHandler.HandleDurationEvent);
    }
}
