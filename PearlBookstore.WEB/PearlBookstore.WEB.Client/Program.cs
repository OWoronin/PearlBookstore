using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddHttpClient("Anonymous", client => client.BaseAddress = new Uri("http://pearlbookstore.api:8080/"));

await builder.Build().RunAsync();
