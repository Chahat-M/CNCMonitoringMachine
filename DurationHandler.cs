using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DurationHandler
{
    public void HandleDurationEvent(int continuousOperationDuration)
    {
        Console.WriteLine($"Duration Event: {continuousOperationDuration}");

        if (continuousOperationDuration > 360)
        {
            // Alert for machine
            MachineController.Instance.NotifyMachine($"Continuous operation exceeds 6 hours: {continuousOperationDuration} minutes");
        }

    }
}
