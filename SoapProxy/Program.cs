// See https://aka.ms/new-console-template for more information

using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using SoapProxy;
using SoapProxy.IDbObjectsInfoService;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();
builder.AddSerilog();

builder.Services.AddTransient<IDbObjectsInfoService>(_ =>
{
    const DbObjectsInfoServiceClient.EndpointConfiguration ENDPOINT_CONFIGURATION = DbObjectsInfoServiceClient.EndpointConfiguration.BasicHttpBinding_IDbObjectsInfoService_soap;
    const string REMOTE_ADDRESS = "http://localhost:5000/DbObjectsInfoService.asmx";
    return new DbObjectsInfoServiceClient(ENDPOINT_CONFIGURATION, REMOTE_ADDRESS);
});

builder.Services.AddMvc().AddNewtonsoftJson(options =>
{
    options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
    options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
    options.SerializerSettings.Converters.Add(new StringEnumConverter());
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.Configure<RouteOptions>(options => options.LowercaseUrls = true);
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "My API",
        Version = "v1"
    });

    string xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    string xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);
});

WebApplication app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.MapControllers();

app.Run();