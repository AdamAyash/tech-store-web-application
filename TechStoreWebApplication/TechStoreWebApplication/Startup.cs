using Microsoft.EntityFrameworkCore;
using TechStoreWebApplication.Database;
using TechStoreWebApplication.Repository.CategoryRepository;
using TechStoreWebApplication.Repository.ProductRepository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<TechStoreDbContext>
    (options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();

var app = builder.Build();

app.UseStaticFiles();

if (app.Environment.IsDevelopment())
    app.UseDeveloperExceptionPage();

app.MapDefaultControllerRoute();
DbInitializer.Seed(app);
app.Run();

