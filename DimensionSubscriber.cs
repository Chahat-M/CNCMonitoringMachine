using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

public class DimensionSubscriber
{
    private readonly DimensionHandler dimensionHandler;

    public DimensionSubscriber(DimensionHandler dimensionHandler)
    {
        this.dimensionHandler = dimensionHandler;
        EventAggregator.Instance.Events.Subscribe<double>(dimensionHandler.HandleDimensionEvent);
    }
}
