namespace MDD4All.SpecIF.DataProvider.Contracts
{
    public interface ISpecIfDataProviderFactory
    {
        ISpecIfMetadataReader GetSpecIfMetadataReader();

        ISpecIfMetadataWriter GetSpecIfMetadataWriter();

        ISpecIfDataReader GetSpecIfDataReader();

        ISpecIfDataWriter GetSpecIfDataWriter();
    }
}
