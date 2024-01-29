using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EventManager
{
    private readonly Dictionary<Type, Delegate> eventHandlers = new Dictionary<Type, Delegate>();

    public void Subscribe<T>(Action<T> handler)
    {
        if (!eventHandlers.ContainsKey(typeof(T)))
        {
            eventHandlers[typeof(T)] = handler;
        }
        else
        {
            eventHandlers[typeof(T)] = (eventHandlers[typeof(T)] as Action<T>) + handler;
        }
    }

    public void Unsubscribe<T>(Action<T> handler)
    {
        if (eventHandlers.TryGetValue(typeof(T), out var currentHandler))
        {
            eventHandlers[typeof(T)] = (eventHandlers[typeof(T)] as Action<T>) - handler;
        }
    }

    public void PublishEvent<T>(T eventArgs)
    {
        if (eventHandlers.TryGetValue(typeof(T), out var handler))
        {
            (handler as Action<T>)?.Invoke(eventArgs);
        }
    }
}
