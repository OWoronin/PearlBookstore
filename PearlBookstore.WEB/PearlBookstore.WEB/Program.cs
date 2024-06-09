using Blazored.LocalStorage;
using MudBlazor;
using MudBlazor.Services;
using PearlBookstore.WEB.Client.Services;
using PearlBookstore.WEB.Components;

var builder = WebApplication.CreateBuilder(args);
//StaticWebAssetsLoader.UseStaticWebAssets(builder.Environment, builder.Configuration);
// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins("http://pearlbookstore.web", "http://localhost:20220");
        policy.AllowAnyHeader();
        policy.AllowAnyMethod();
    });
});

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
//builder.Services.AddScoped<CurrentUser>();
builder.Services.AddSingleton<EventAggregator>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseCors();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(PearlBookstore.WEB.Client._Imports).Assembly);

app.Run();
