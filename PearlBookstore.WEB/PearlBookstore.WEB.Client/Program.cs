using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor;
using MudBlazor.Services;
using PearlBookstore.WEB.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

//builder.Services.AddHttpClient("API", client => client.BaseAddress = new Uri("https://pearlbookstore.api:8080/"));
builder.Services.AddHttpClient("API", client => client.BaseAddress = new Uri("http://localhost:10110/"));

builder.Services.AddMudServices(config =>
{
    config.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.TopEnd;
    config.SnackbarConfiguration.PreventDuplicates = false;
    config.SnackbarConfiguration.NewestOnTop = false;
    config.SnackbarConfiguration.ShowCloseIcon = true;
    config.SnackbarConfiguration.VisibleStateDuration = 2500;
    config.SnackbarConfiguration.HideTransitionDuration = 500;
    config.SnackbarConfiguration.ShowTransitionDuration = 500;
    config.SnackbarConfiguration.SnackbarVariant = Variant.Filled;
});

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddSingleton<BuyItemsService>();
builder.Services.AddSingleton<ReturnItemsService>();
builder.Services.AddSingleton<OrderItemsService>();
builder.Services.AddScoped<CurrentUserService>();
builder.Services.AddSingleton<EventAggregator>();

await builder.Build().RunAsync();
