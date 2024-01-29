using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SelfTestHandler
{
    public void HandleSelfTestEvent(int statusCode)
    {
        Console.WriteLine($"Self Test Event: {statusCode}");

        if (statusCode != 0xFF)
        {
            // Alert for machine
            MachineController.Instance.NotifyMachine($"Self-test status indicates an issue: {statusCode}");
        }
    }
}
