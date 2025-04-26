using Microsoft.EntityFrameworkCore;
using jugadores_futbol.Data;

var builder = WebApplication.CreateBuilder(args);

// Agrega soporte a PostgreSQL con EF Core
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Agrega MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Manejo de errores y HSTS
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

// Middleware
app.UseHttpsRedirection();
app.UseStaticFiles(); // 👈 Necesario para archivos estáticos

app.UseRouting();
app.UseAuthorization();

// Rutas por defecto
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
