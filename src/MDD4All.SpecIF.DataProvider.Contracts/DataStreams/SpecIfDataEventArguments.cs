using MDD4All.SpecIF.DataModels;
using System;
using System.Collections.Generic;

namespace MDD4All.SpecIF.DataProvider.Contracts.DataStreams
{
    public class SpecIfDataEventArguments : EventArgs
    {
        public List<Resource> Data { get; set; } = new List<Resource>();

        public Dictionary<string, string> Metadata { get; set; } = null;
    }
}
