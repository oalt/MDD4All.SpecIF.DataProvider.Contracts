namespace MDD4All.SpecIF.DataProvider.Contracts
{
    public interface ISpecIfDataProviderFactory
    {
        ISpecIfMetadataReader MetadataReader { get; set; }
        
        ISpecIfMetadataWriter MetadataWriter { get; set; }

        ISpecIfDataReader DataReader { get; set; }   

        ISpecIfDataWriter DataWriter { get; set; }   
    }
}
