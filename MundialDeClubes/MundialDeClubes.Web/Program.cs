using Microsoft.EntityFrameworkCore;
using MundialDeClubes.Entidades.EF;
using MundialDeClubes.Logica.Interfaces;
using MundialDeClubes.Logica.Repositories;
using MundialDeClubes.Logica.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IClubRepository, ClubRepository>();
builder.Services.AddScoped<IClubService, ClubService>();
builder.Services.AddScoped<IJugadorEstrellaRepository, JugadorEstrellaRepository>();
builder.Services.AddScoped<IJugadorEstrellaService, JugadorEstrellaService>();
builder.Services.AddScoped<IPresidenteRepository, PresidenteRepository>();
builder.Services.AddScoped<IPresidenteService, PresidenteService>();

builder.Services.AddDbContext<MundialDeClubesContext>(options =>
  options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
