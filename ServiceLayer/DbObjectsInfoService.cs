namespace ServiceLayer;

public class DbObjectsInfoService : IDbObjectsInfoService
{
    public Table[] GetTables()
    {
        return new[]
        {
            new Table
            {
                Name = "Table 1"
            },
            new Table
            {
                Name = "Table 2"
            }
        };
    }
}