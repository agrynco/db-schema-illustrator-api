namespace ServiceLayer;

using System.ServiceModel;

[ServiceContract]
public interface IDbObjectsInfoService
{
    [OperationContract]
    [FaultContract(typeof(MissingTablesFault))]
    TableInfo[] GetTables(string schemaName);

    [OperationContract]
    ForeignKeyInfo[] GetForeignKeys(string schemaName);

    [OperationContract]
    string[] GetSchemas();
}