using Microsoft.EntityFrameworkCore;
using MVCCRUDDemo.DBContext;
using MVCCRUDDemo.Repositories;
using MVCCRUDDemo.Repositories.Interfaces;
using MVCCRUDDemo.Services;
using MVCCRUDDemo.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("MVCConnectionString");

builder.Services.AddDbContext<MVCDbContext>(
    options => options.UseSqlServer(connectionString));

if (builder.Environment.IsDevelopment())
{
    builder.Services.AddScoped<IFriendService, FriendService>();
}
else
{
    builder.Services.AddScoped<IFriendService, StubFriendService>();
}

builder.Services.AddScoped<IFriendRepository, FriendRepository>();

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
