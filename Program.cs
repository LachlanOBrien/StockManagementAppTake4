using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StockManagementApp.Areas.Identity.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("StockManagementAppContextConnection") ?? throw new InvalidOperationException("Connection string 'StockManagementAppContextConnection' not found.");;

builder.Services.AddDbContext<StockManagementAppContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<StockManagementAppUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<StockManagementAppContext>();

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
    add the sql inserts into the db initalizer
    add comments throught the models explaining the validation
    do the test cases
    do the relevant implications
    update the class diagram to have the var names
    do the use case diagram and flowchart
*/