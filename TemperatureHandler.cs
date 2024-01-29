using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TemperatureHandler
{
    public void HandleTemperatureEvent(double temperature)
    {
        Console.WriteLine($"Temperature Event: {temperature}");

        if (temperature > 35)
        {
            // Alert for environment
            EnvironmentController.Instance.NotifyEnvironment($"Temperature exceeded 35 degrees: {temperature}");
        }
    }
}
