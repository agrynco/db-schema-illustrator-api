using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using ServiceLayer;
using SoapCore;
using SoapProxy;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();
builder.AddSerilog();

builder.Services.AddSoapCore();

builder.Services.TryAddSingleton<DbObjectsInfoService>();

builder.Services.TryAddTransient<IDbObjectsInfoServiceConfiguration>(_ => new DbObjectsInfoServiceConfiguration
{
    ConnectionString = builder.Configuration.GetConnectionString("Default")!
});

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