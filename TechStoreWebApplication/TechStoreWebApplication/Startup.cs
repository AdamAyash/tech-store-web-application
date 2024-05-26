using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.EntityFrameworkCore;
using TechStoreWebApplication.Database;
using TechStoreWebApplication.Models;
using TechStoreWebApplication.Repository;
using TechStoreWebApplication.Repository.CategoryRepository;
using TechStoreWebApplication.Repository.ProductRepository;
using TechStoreWebApplication.Repository.ShoppingCart;

public class Startup
{
    public static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);


        builder.Services.AddControllersWithViews();
        builder.Services.AddDbContext<TechStoreDbContext>
            (options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
        builder.Services.AddDefaultIdentity<IdentityUser>()
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<TechStoreDbContext>();

        builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
        builder.Services.AddScoped<IProductRepository, ProductRepository>();
        builder.Services.AddScoped<IShoppingCart, ShoppingCart>(sp => ShoppingCart.GetCart(sp));
        builder.Services.AddScoped<IOrderRepository, OrderRepository>();
        builder.Services.AddSession();
        builder.Services.AddHttpContextAccessor();
        builder.Services.AddRazorPages();


        var app = builder.Build();

        app.UseStaticFiles();
        app.UseSession();

        app.UseAuthentication();
        app.MapDefaultControllerRoute();
        app.MapRazorPages();

        app.UseHttpsRedirection();
        app.UseRouting();


        app.UseAntiforgery();
        app.UseAuthorization();



        if (app.Environment.IsDevelopment())
            app.UseDeveloperExceptionPage();

        DbInitializer.Seed(app);

        //using (var scope = app.Services.CreateScope())
        //{
        //    var roleManager = scope.ServiceProvider.GetService<RoleManager<IdentityRole>>();

        //    var roles = new[] { "User", "Admin" };

        //    foreach (var role in roles)
        //    {
        //        if (!await roleManager.RoleExistsAsync(role))
        //            await roleManager.CreateAsync(new IdentityRole(role));

        //    }

        //    var userMangager = scope.ServiceProvider.GetService<UserManager<IdentityUser>>();

        //    string email = "admin@mail.com";
        //    string password = "12345";


        //    if(await userMangager.FindByEmailAsync(email) == null)
        //    {
        //        var user = new IdentityUser();
        //        user.UserName = email;
        //        user.Email = email;

        //        await userMangager.CreateAsync(user, password);

        //        await userMangager.AddToRoleAsync(user, "Admin");
        //    }
        //}
        app.Run();
    }
}

