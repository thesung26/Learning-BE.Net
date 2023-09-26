var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

var objBuilder = new ConfigurationBuilder()
		  .SetBasePath(Directory.GetCurrentDirectory())
		  .AddJsonFile("appSettings.json", optional: true, reloadOnChange: true);
IConfiguration conManager = objBuilder.Build();
var my = conManager.GetConnectionString("DefaultConnection");

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
