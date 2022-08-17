using BlazorWasmAcademy;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Radzen;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient {BaseAddress = new Uri("https://localhost:7205")});
// builder.Services.AddScoped(sp => new HttpClient {BaseAddress = new Uri("https://blazor-wasm-academy-server.herokuapp.com/")});
builder.Services.AddTransient<IAppointmentClient, AppointmentClient>();
builder.Services.AddTransient<IAccessClient, AccessClient>();
builder.Services.AddScoped<DialogService>();
builder.Services.AddScoped<NotificationService>();

await builder.Build().RunAsync();