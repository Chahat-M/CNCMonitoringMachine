using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public sealed class EnvironmentController
{
    private static readonly EnvironmentController instance = new EnvironmentController();

    public static EnvironmentController Instance => instance;

    private EnvironmentController() { }

    public void NotifyEnvironment(string message)
    {
        Console.WriteLine($"Environment Alert: {message}. Notify environment personnel.");
        // Your notification logic here...
    }
}
