using MDD4All.SpecIF.DataModels;
using System.Collections.Generic;

namespace MDD4All.SpecIF.DataProvider.Contracts.DataStreams
{
    public interface ISpecIfDataPublisher
    {
        void PublishData(List<Resource> specIfdata, Dictionary<string, string> metadata = null);
    }
}
