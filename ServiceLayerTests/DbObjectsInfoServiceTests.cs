namespace ServiceLayerTests;

using ServiceLayer;
using Xunit;

public class DbObjectsInfoServiceTests
{
    [Fact]
    public void GetSchemas_ShouldReturnAllSchemaNames()
    {
        // Arrange
        DbObjectsInfoService service = BuildDbObjectsInfoService();

        // Act
        SchemaInfo[] schemas = service.GetSchemas();

        // Assert
        Assert.Equal(18, schemas.Length);
    }

    private static DbObjectsInfoService BuildDbObjectsInfoService()
    {
        var service =
            new DbObjectsInfoService(
                new DbObjectsInfoServiceConfiguration
                {
                    ConnectionString ="Server=127.0.0.1;Database=AdventureWorks2022;User Id=sa;Password=k6bR%YM3;TrustServerCertificate=true;"
                });
        return service;
    }

    [Fact]
    public void GetTables_ShouldReturnTableInfoForPersonSchema()
    {
        // Arrange
        DbObjectsInfoService service = BuildDbObjectsInfoService();

        // Act
        var tableInfos = service.GetTables("Person");

        // Assert
        Assert.Equal(13, tableInfos.Length);
    }

    [Fact]
    public void GetForeignKeys_ShouldReturnForeignKeysForPersonSchema()
    {
        // Arrange
        DbObjectsInfoService service = BuildDbObjectsInfoService();

        // Act
        var foreignKeys = service.GetForeignKeys("Person");

        // Assert
        Assert.Equal(14, foreignKeys.Length);
    }
}