using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public sealed class MachineController
{
    private static readonly MachineController instance = new MachineController();

    public static MachineController Instance => instance;

    private MachineController() { }

    public void NotifyMachine(string message)
    {
        Console.WriteLine($"Machine Alert: {message}. Notify machine personnel.");
        // Your notification logic here...
    }
}
