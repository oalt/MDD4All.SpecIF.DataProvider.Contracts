using System;

namespace MDD4All.SpecIF.DataProvider.Contracts.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class SpecIfResourceAttribute : Attribute
    {
        private string _resourceClassTitle = "";

        public string ResourceClassID { get; set; } = "";
        public string ResourceClassRevision { get; set; } = "";

        public SpecIfResourceAttribute(string resourceClassTitle)
        {
            _resourceClassTitle = resourceClassTitle;
        }

    }
}
