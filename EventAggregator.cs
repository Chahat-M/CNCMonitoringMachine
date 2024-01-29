using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public sealed class EventAggregator
{
    private static readonly EventAggregator instance = new EventAggregator();
    private readonly EventManager eventManager = new EventManager();

    public static EventAggregator Instance => instance;

    private EventAggregator() { }

    public EventManager Events => eventManager;
}

