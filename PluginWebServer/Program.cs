using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using PluginWebServer;
using PluginWebServer.Component;
using PluginWebServer.Data;
using Pokebox;
using System.Reflection;
using Syncfusion.Blazor;
using Syncfusion.Licensing;

var builder = WebApplication.CreateBuilder(args);
SyncfusionLicenseProvider.RegisterLicense("@32302e342e30hvt4RS1te/ZqCk/cvv2iWHqM4d+ljkJcBAtqVnf6LAg=");

bool isValid = SyncfusionLicenseProvider.ValidateLicense(Platform.Blazor);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSyncfusionBlazor();

builder.Services.AddSingleton<WeatherForecastService>();

builder.Services.AddDbContextFactory<PokeboxContext>();
//builder.Services.AddScoped<IPokeboxService, PokeboxService>();

builder.Services.AddSingleton<IPluginComponentService>(_ =>
{
    var service = new PluginComponentService();
    service.LoadComponents(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
    return service;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

