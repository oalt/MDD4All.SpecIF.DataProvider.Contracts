using System;

namespace MDD4All.SpecIF.DataProvider.Contracts.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class SpecIfPropertyValuesAttribute : Attribute
    {
        private string _propertyClassTitle = "";

        public string PropertyClassID { get; set; } = "";
        public string PropertyClassRevision { get; set; } = "";

        public SpecIfPropertyValuesAttribute(string propertyClassTitle)
        {
            _propertyClassTitle = propertyClassTitle;
        }
    }
}
