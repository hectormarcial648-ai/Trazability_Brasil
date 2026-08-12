using TrazabilityBrasil.Components;
using Microsoft.EntityFrameworkCore;
using TrazabilityBrasil.Data;
using Microsoft.AspNetCore.Authentication.Negotiate;
using Microsoft.AspNetCore.Mvc; // Necesario para IgnoreAntiforgeryTokenAttribute

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContextFactory<ConexionesBral>(options =>
      options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionMachine_db")));

builder.Services.AddQuickGridEntityFrameworkAdapter();

//builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Add services to the container.
//Console.WriteLine("Agregando componentes...");
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

//Console.WriteLine("Fin de agregar componentes");

// AGREGAR EL SERVICIO DE DATOS

// Configura Windows Authentication (Negotiate)
/* Desactiva la autenticación por windows para evitar bug
builder.Services.AddAuthentication(NegotiateDefaults.AuthenticationScheme)
    .AddNegotiate();
*/

// Configura la política de autorización para requerir autenticación por defecto
/* Desactiva la autorización
builder.Services.AddAuthorization(options =>
{
    options.FallbackPolicy = options.DefaultPolicy;
});
*/

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
//app.UseAuthentication();
//app.UseAuthorization();
app.UseAntiforgery();

// Al mapear el endpoint de Blazor, indicamos que ignore la validación antiforgery
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .WithMetadata(new IgnoreAntiforgeryTokenAttribute());

app.Run();