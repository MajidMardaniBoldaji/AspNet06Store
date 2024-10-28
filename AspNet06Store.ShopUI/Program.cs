using AspNet06Store.ShopUI.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var CS = builder.Configuration.GetConnectionString("CNString");
builder.Services.AddDbContext<StoreDbContext>(option => option.UseSqlServer(CS));
builder.Services.AddScoped<IProductRepoitory,EfProductRepository>();
builder.Services.AddMemoryCache();
builder.Services.AddSession();
var app = builder.Build();
app.UseDeveloperExceptionPage();
app.UseStatusCodePages();
app.UseStaticFiles();
app.UseSession();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute("pagination", "/{controller=Home}/{action=Index}/{category}page{PageNumber}");
    endpoints.MapControllerRoute("pagination", "/{controller=Home}/{action=Index}/page{PageNumber}");
    endpoints.MapControllerRoute("pagination", "/{controller=Home}/{action=Index}/{category}");
    endpoints.MapDefaultControllerRoute();
}
);


app.Run();
