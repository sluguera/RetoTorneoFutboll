using Torneo.App.Persistencia;
using Torneo.App.Persistencia.AppRepositorios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSingleton<IRepositorioMunicipio, RepositorioMunicipio>();
builder.Services.AddSingleton<IRepositorioDirectorTecnico, RepositorioDirectorTecnico>();
builder.Services.AddSingleton<IRepositorioEquipo, RepositorioEquipo>();
builder.Services.AddSingleton<IRepositorioPosicion, RepositorioPosicion>();
builder.Services.AddSingleton<IRepositorioPartido, RepositorioPartido>();
builder.Services.AddSingleton<IRepositorioJugador, RepositorioJugador>();


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

app.UseAuthorization();

app.MapRazorPages();

app.Run();
