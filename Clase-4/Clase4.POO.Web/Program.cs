using Clase4.POO.Entidades;
using Clase4.POO.Logica;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IEquiposLogica, EquiposLogica>();
builder.Services.AddSingleton<IAnimalesLogica, AnimalesLogica>();
builder.Services.AddSingleton<IAnimalCreator, PerroCreator>();
builder.Services.AddSingleton<IAnimalCreator, GatoCreator>();
builder.Services.AddSingleton<IAnimalCreator, VacaCreator>();
builder.Services.AddSingleton<IAnimalCreator, GallinaCreator>();
builder.Services.AddSingleton<IAnimalCreator, LeonCreator>();
builder.Services.AddSingleton<AnimalFactory>();

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
    pattern: "{controller=Animales}/{action=Listar}/{id?}");

app.Run();
