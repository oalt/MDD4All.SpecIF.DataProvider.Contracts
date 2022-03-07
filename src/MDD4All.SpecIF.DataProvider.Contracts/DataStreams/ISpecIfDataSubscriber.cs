namespace MDD4All.SpecIF.DataProvider.Contracts.DataStreams
{

    public delegate void SpecIfDataReceivedEventHandler(object eventSource, 
                                                        SpecIfDataEventArguments specIfDataEventArguments);

    public interface ISpecIfDataSubscriber
    {
        event SpecIfDataReceivedEventHandler SpecIfDataReceived;

        
    }
}
