using AspNet06Store.ShopUI.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var CS = builder.Configuration.GetConnectionString("CNString");
builder.Services.AddDbContext<StoreDbContext>(option => option.UseSqlServer(CS));
builder.Services.AddScoped<IProductRepoitory,EfProductRepository>();    
var app = builder.Build();
app.UseDeveloperExceptionPage();
app.UseStatusCodePages();
app.UseStaticFiles();
app.UseRouting();
app.UseEndpoints(endpoints =>
endpoints.MapDefaultControllerRoute());


app.Run();
