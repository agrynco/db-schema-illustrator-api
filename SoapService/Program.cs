using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection.Extensions;
using ServiceLayer;
using SoapCore;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddSoapCore();

builder.Services.TryAddSingleton<DbObjectsInfoService>();

WebApplication app = builder.Build();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.UseSoapEndpoint<DbObjectsInfoService>(
        "/DbObjectsInfoService.asmx",
        new SoapEncoderOptions(),
        SoapSerializer.XmlSerializer,
        true);
});

app.Run();