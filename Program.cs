using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StockManagementApp.Areas.Identity.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("StockManagementAppContextConnection") ?? throw new InvalidOperationException("Connection string 'StockManagementAppContextConnection' not found.");;

builder.Services.AddDbContext<StockManagementAppContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<StockManagementAppUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<StockManagementAppContext>()
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<StockManagementAppContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<StockManagementAppContext>();
        var userManager = services.GetRequiredService<UserManager<StockManagementAppUser>>();
        var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
        DbInitializer.Initialize(context, userManager, roleManager);
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred creating the DB.");
    }
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
/*
- to do list
add images into the database 
suppliers users items table require images 
*/