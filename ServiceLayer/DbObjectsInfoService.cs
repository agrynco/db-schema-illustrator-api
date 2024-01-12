namespace ServiceLayer;

using System.Data.Common;
using System.Reflection;
using Microsoft.Data.SqlClient;

public class DbObjectsInfoService : IDbObjectsInfoService
{
    private readonly string _connectionString;

    public DbObjectsInfoService(string connectionString) { _connectionString = connectionString; }

    public ForeignKeyInfo[] GetForeignKeys(string schemaName)
    {
        using var sqlConnection = new SqlConnection(_connectionString);

        using var sqlCommand = new SqlCommand(GetSql("ServiceLayer.GetForeignKeys.sql"), sqlConnection);

        sqlCommand.Parameters.AddWithValue("@schemaName", schemaName);

        sqlConnection.Open();
        using SqlDataReader reader = sqlCommand.ExecuteReader();

        List<ForeignKeyInfo> foreignKeys = new();
        
        while (reader.Read())
        {
            foreignKeys.Add(new ForeignKeyInfo
            {
                ConstraintName = reader["ConstraintName"].ToString(),
                ForeignKeyColumnName = reader["ForeignKeyColumn"].ToString(),
                ForeignKeyTableName = reader["ForeignKeyTable"].ToString(),
                PrimaryKeyColumnName = reader["PrimaryKeyColumn"].ToString(),
                PrimaryKeyTableName = reader["PrimaryKeyTable"].ToString()
            });
        }

        return foreignKeys.ToArray();
    }

    public string[] GetSchemas()
    {
        using DbConnection dbConnection = new SqlConnection(_connectionString);

        dbConnection.Open();

        using DbCommand dbCommand = dbConnection.CreateCommand();
        dbCommand.CommandText = "SELECT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA";

        using DbDataReader dbDataReader = dbCommand.ExecuteReader();

        var schemas = new List<string>();
        while (dbDataReader.Read())
        {
            schemas.Add(dbDataReader.GetString(0));
        }

        return schemas.ToArray();
    }
    
    public TableInfo[] GetTables(string schemaName)
    {
        using var sqlConnection = new SqlConnection(_connectionString);

        using var sqlCommand = new SqlCommand(GetSql("ServiceLayer.GetColumns.sql"), sqlConnection);

        sqlCommand.Parameters.AddWithValue("@schemaName", schemaName);

        sqlConnection.Open();
        using SqlDataReader reader = sqlCommand.ExecuteReader();

        Dictionary<string, TableInfo> tablesDictionary = new();

        while (reader.Read())
        {
            string tableName = reader["TABLE_NAME"].ToString()!;

            if (!tablesDictionary.TryGetValue(tableName, out TableInfo tableInfo))
            {
                tableInfo = new TableInfo
                {
                    Name = reader["TABLE_NAME"].ToString()!,
                    Columns = new List<ColumnInfo>()
                };

                tablesDictionary.Add(tableName, tableInfo);
            }

            tableInfo.Columns.Add(new ColumnInfo
            {
                Name = reader["COLUMN_NAME"].ToString()!,
                IsPrimary = reader["IsPrimaryKey"].ToString() == "Yes"
            });
        }

        return tablesDictionary.Values.ToArray();
    }

    private string GetSql(string resourceName)
    {
        using Stream? stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName);
        if (stream == null)
        {
            throw new InvalidOperationException($"Could not find embedded resource '{resourceName}'");
        }

        using var reader = new StreamReader(stream);
        return reader.ReadToEnd();
    }
}