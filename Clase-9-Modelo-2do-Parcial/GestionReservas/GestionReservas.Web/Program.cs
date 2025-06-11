using GestionReservas.Data.EF;
using GestionReservas.Logica;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<_20251cModel2doPGestionReservasContext>();
builder.Services.AddScoped<IReservaLogica, ReservaLogica>();
builder.Services.AddScoped<IDestinoLogica, DestinoLogica>();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Reservas}/{action=Visualizar}/{id?}")
    .WithStaticAssets();


app.Run();
