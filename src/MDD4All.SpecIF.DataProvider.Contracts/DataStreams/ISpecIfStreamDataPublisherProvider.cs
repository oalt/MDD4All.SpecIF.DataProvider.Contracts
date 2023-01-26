namespace MDD4All.SpecIF.DataProvider.Contracts.DataStreams
{
    public interface ISpecIfStreamDataPublisherProvider
    {
        ISpecIfDataPublisher StreamDataPublisher { get; set; }
    }
}
