using AspNet06Store.ShopUI.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var CS = builder.Configuration.GetConnectionString("CNString");
builder.Services.AddDbContext<StoreDbContext>(option => option.UseSqlServer(CS));
builder.Services.AddScoped<IProductRepoitory,EfProductRepository>();
builder.Services.AddScoped<IOrderRepository,EFOrderRepository>();
//builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddMemoryCache();
builder.Services.AddSession();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Auth/Login";
        options.LogoutPath = "/Auth/Logout";
    });

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddScoped<Basket>(c => SessionBasket.GetBasket(c));
var app = builder.Build();
app.UseDeveloperExceptionPage();
app.UseStatusCodePages();
app.UseStaticFiles();
app.UseSession();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();



app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute("pagination", "/{controller=Home}/{action=Index}/{category}page{PageNumber}");
    endpoints.MapControllerRoute("pagination", "/{controller=Home}/{action=Index}/page{PageNumber}");
    endpoints.MapControllerRoute("pagination", "/{controller=Home}/{action=Index}/{category}");
    endpoints.MapDefaultControllerRoute();
}
);


app.Run();
