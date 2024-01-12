namespace ServiceLayer;

public interface IDbObjectsInfoServiceConfiguration
{
    string ConnectionString { get; }
}

public record DbObjectsInfoServiceConfiguration : IDbObjectsInfoServiceConfiguration
{
    public string ConnectionString { get; init; }
}