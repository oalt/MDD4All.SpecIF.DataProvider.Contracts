namespace MDD4All.SpecIF.DataProvider.Contracts
{
    public abstract class AbstractSpecIfDataProviderFactory : ISpecIfDataProviderFactory
    {
        protected static ISpecIfMetadataReader _metadataReader { get; set; }

        protected static ISpecIfMetadataWriter _metadataWriter { get; set; }

        protected static ISpecIfDataReader _dataReader { get; set; }

        protected static ISpecIfDataWriter _dataWriter { get; set; }

        public ISpecIfDataReader GetSpecIfDataReader()
        {
            return _dataReader;
        }

        public ISpecIfDataWriter GetSpecIfDataWriter()
        {
            return _dataWriter;
        }

        public ISpecIfMetadataReader GetSpecIfMetadataReader()
        {
            return _metadataReader;
        }

        public ISpecIfMetadataWriter GetSpecIfMetadataWriter()
        {
            return _metadataWriter;
        }

        protected abstract void InitializeDataProviders();
    }
}
