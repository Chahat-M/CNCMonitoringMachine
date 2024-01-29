using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DimensionHandler
{
    public void HandleDimensionEvent(double dimensionVariation)
    {
        Console.WriteLine($"Dimension Event: {dimensionVariation}");

        if (dimensionVariation > 0.05)
        {
            // Alert for machine
            MachineController.Instance.NotifyMachine($"Part-dimension variation exceeds 0.05 mm: {dimensionVariation}");
        }
    }
}
