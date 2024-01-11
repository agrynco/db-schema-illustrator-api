using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection.Extensions;
using ServiceLayer;
using SoapCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSoapCore();

builder.Services.TryAddSingleton<DbObjectsInfoService>();

var app = builder.Build();
app.UseRouting();

app.UseEndpoints(endpoints => { 
    endpoints.UseSoapEndpoint<DbObjectsInfoService>(
        path: "/DbObjectsInfoService.asmx", 
        encoder: new SoapEncoderOptions(), 
        serializer: SoapSerializer.DataContractSerializer, 
        caseInsensitivePath: true); });

app.Run();