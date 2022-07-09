using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCWebApp.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MVCWebAppContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MVCWebAppContext") ?? throw new InvalidOperationException("Connection string 'MVCWebAppContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

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
    // routing format is set here
    // when browsing and no url segments it defaults to "Home" and the "Index" below
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
