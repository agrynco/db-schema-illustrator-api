namespace SoapProxy.Controllers;

using Microsoft.AspNetCore.Mvc;
using SoapProxy.IDbObjectsInfoService;

public class SoapProxyController : ApiControllerBase
{
    private readonly IDbObjectsInfoService _dbObjectsInfoService;

    public SoapProxyController(IDbObjectsInfoService dbObjectsInfoService)
    {
        _dbObjectsInfoService = dbObjectsInfoService;
    }

    [HttpGet]
    [Route("tables/{schemaName}")]
    public async Task<IActionResult> GetTables(string schemaName)
    {
        var request = new GetTablesRequest
        {
            Body = new GetTablesRequestBody
            {
                schemaName = schemaName
            }
        };

        return Ok(await _dbObjectsInfoService.GetTablesAsync(request));
    }

    [HttpGet]
    [Route("foreign-keys/{schemaName}")]
    public async Task<IActionResult> GetForeignKeys(
        string schemaName
        )
    {
        var request = new GetForeignKeysRequest
        {
            Body = new GetForeignKeysRequestBody
            {
                schemaName = schemaName
            }
        };

        return Ok(await _dbObjectsInfoService.GetForeignKeysAsync(request));
    }

    [HttpGet]
    [Route("schemas")]
    public async Task<IActionResult> GetSchemas()
    {
        SchemaInfo[]? arrayOfString = await _dbObjectsInfoService.GetSchemasAsync();
        return Ok(arrayOfString);
    }
}