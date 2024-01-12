namespace SoapProxy.Controllers;

using Microsoft.AspNetCore.Mvc;

public class SoapProxyController : ApiControllerBase
{
    [HttpGet]
    [Route("")]
    public async Task<IActionResult> GetDbObjectsInof() { throw new NotImplementedException(); }
}