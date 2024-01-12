namespace SoapProxy.Controllers;

using Microsoft.AspNetCore.Mvc;
using SoapProxy.IDbObjectsInfoService;

public class SoapProxyController : ApiControllerBase
{
    [HttpGet]
    [Route("")]
    public async Task<IActionResult> GetDbObjectsInof()
    {
        var endpointConfiguration = DbObjectsInfoServiceClient.EndpointConfiguration.BasicHttpBinding_IDbObjectsInfoService_soap;

        var serviceClient = new DbObjectsInfoServiceClient(endpointConfiguration);
        
        string remoteAddress = "http://localhost:5000/DbObjectsInfoService.asmx";
        var serviceClientWithRemoteAddress = new DbObjectsInfoServiceClient(endpointConfiguration, remoteAddress);
        
        return Ok(await serviceClientWithRemoteAddress.GetTablesAsync("Person"));
    }
}