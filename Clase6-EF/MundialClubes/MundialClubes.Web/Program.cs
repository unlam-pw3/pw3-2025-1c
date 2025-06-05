using MundialClubes.Entidades.EF;
using MundialClubes.Logica;
using MundialClubes.Web.Mappings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<MundialClubesContext>();
builder.Services.AddScoped<IClubLogica, ClubLogica>();
builder.Services.AddScoped<IJugadorLogica, JugadorLogica>();
builder.Services.AddScoped<IPresidenteLogica, PresidenteLogica>();
builder.Services.AddScoped<ITorneoLogica, TorneoLogica>();

// Registrar AutoMapper y pasar el assembly donde están los perfiles
builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly);


// Agregar servicios de Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else 
{ 
    // Usar Swagger solo en desarrollo (opcional)
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Club}/{action=Lista}/{id?}");

app.Run();
