using System.Reflection;
//using Blazored.SessionStorage;
//using Blazored.Toast;
//using CurrieTechnologies.Razor.SweetAlert2;
//using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using RendicionGastos.Client;
//using RendicionGastos.Client.Auth;
//using Scrutor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddSingleton(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//builder.Services.AddBlazoredSessionStorage();
//builder.Services.AddBlazoredToast();
//builder.Services.AddSweetAlert2();

// Registramos las dependencias de Repositories y Services (SCRUTOR)
//builder.Services.Scan(selector => selector
//    .FromAssemblies(Assembly.GetExecutingAssembly())
//    .AddClasses(false)
//    .UsingRegistrationStrategy(RegistrationStrategy.Skip)
//    .AsMatchingInterface()
//    .WithScopedLifetime());

//builder.Services.AddScoped<AuthenticationStateProvider, AuthenticationService>();
builder.Services.AddAuthorizationCore();
await builder.Build().RunAsync();
