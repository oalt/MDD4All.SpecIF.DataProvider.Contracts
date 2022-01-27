using MDD4All.SpecIF.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MDD4All.SpecIF.DataProvider.Contracts.DataStreams
{

    public delegate void SpecIfDataReceivedEventHandler(object eventSource, List<Resource> specIfData);

    public interface ISpecIfDataSubscriber
    {
        event SpecIfDataReceivedEventHandler SpecIfDataReceived;
    }
}
