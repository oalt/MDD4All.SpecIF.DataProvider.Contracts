namespace MDD4All.SpecIF.DataProvider.Contracts.DataStreams
{
    public interface ISpecIfStreamDataSubscriberProvider
    {
        ISpecIfDataSubscriber StreamDataSubscriber { get; set; }
    }
}
