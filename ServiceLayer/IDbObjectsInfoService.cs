namespace ServiceLayer;

using System.ServiceModel;

[ServiceContract]
public interface IDbObjectsInfoService
{
    [OperationContract]
    [FaultContract(typeof(MissingTablesFault))]
    Table[] GetTables();
}