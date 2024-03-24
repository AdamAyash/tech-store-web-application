using Microsoft.EntityFrameworkCore;
using TechStoreWebApplication.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<WebAppDbContext>
    (options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

app.UseStaticFiles();

if (app.Environment.IsDevelopment())
    app.UseDeveloperExceptionPage();

app.MapDefaultControllerRoute();
app.Run();

