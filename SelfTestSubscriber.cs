using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

public class SelfTestSubscriber
{
    private readonly SelfTestHandler selfTestHandler;

    public SelfTestSubscriber(SelfTestHandler selfTestHandler)
    {
        this.selfTestHandler = selfTestHandler;
        EventAggregator.Instance.Events.Subscribe<int>(selfTestHandler.HandleSelfTestEvent);
    }
}
